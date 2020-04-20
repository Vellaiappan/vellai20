package com.iss.memorygame;

import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.Random;


public class PlayActivity extends AppCompatActivity implements View.OnClickListener {

    final static int NUMBER_OF_IMAGEVIEWS = 12;

    private int firstImage;
    private View firstView;
    private boolean isFirstTurn;
    private int score;

    private int[] index = new int[]{0, 1, 2, 3, 4, 5, 0, 1, 2, 3, 4, 5};
    private Bitmap[] bitmaps = null;

    TextView scoreView;

    TextView timerTextView;
    long startTime = 0;

    Handler timerHandler = new Handler();
    Runnable timerRunnable = new Runnable() {

        @Override
        public void run() {
            long millis = System.currentTimeMillis() - startTime;
            int milliseconds = (int)(millis/10);
            int seconds = (int) (millis / 1000);
            int minutes = seconds / 60;
            milliseconds = milliseconds%100;
            seconds = seconds % 60;

            timerTextView.setText(String.format("%02d:%02d:%02d", minutes, seconds, milliseconds));

            timerHandler.postDelayed(this, 50);
        }
    };

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_play);

        timerTextView = findViewById(R.id.timerTextView);
        startTime = System.currentTimeMillis();
        timerHandler.postDelayed(timerRunnable, 0);

        isFirstTurn = true;
        score = 0;
        scoreView = findViewById(R.id.score);

        // shuffle the sequence of the images
        shuffle(index);

        // get 6 image paths from intent extra
        Bundle extras = getIntent().getExtras();
        if (extras == null)
            return;
        String[] imagePaths = extras.getStringArray("imagePaths");

        // convert 6 images from internal storage to bitmaps
        if (imagePaths != null) {
            Bitmap bm1 = BitmapFactory.decodeFile(imagePaths[0]);
            Bitmap bm2 = BitmapFactory.decodeFile(imagePaths[1]);
            Bitmap bm3 = BitmapFactory.decodeFile(imagePaths[2]);
            Bitmap bm4 = BitmapFactory.decodeFile(imagePaths[3]);
            Bitmap bm5 = BitmapFactory.decodeFile(imagePaths[4]);
            Bitmap bm6 = BitmapFactory.decodeFile(imagePaths[5]);
            bitmaps = new Bitmap[]{bm1, bm2, bm3, bm4, bm5, bm6};
        }

        // set OnClickListener on all 12 ImageViews
        for (int i = 1; i <= NUMBER_OF_IMAGEVIEWS; i++) {
            String imageViewId = "image_" + i;
            int resId = getResources().getIdentifier(imageViewId, "id", getPackageName());
            ImageView imageView = findViewById(resId);
            imageView.setOnClickListener(this);
        }
    }

    @Override
    public void onClick(View v) {
        // do not do anything if image is already open
        if (isFlippedOpen(v))
            return;

        // get last number of ImageView Id because that indicates the position
        int resId = v.getId();
        String imageViewId = getResources().getResourceEntryName(resId);
        int position = Integer.parseInt(imageViewId.substring(6)) - 1;

        // get the image index to know which of the 6 images was flipped open
        int currentImage = index[position];

        // flip open image
        flipOpen((ImageView) v, currentImage);

        // check if this is first or second turn
        if (isFirstTurn) {
            isFirstTurn = false;
            firstImage = currentImage;
            firstView = v;
        } else {
            isFirstTurn = true;
            // check if the 2 images match
            // if the 2 images match, add score
            if (currentImage == firstImage) {
                score++;
                updateScore();
                // check if game is completed, return to first screen
                if (score == 6) {
                    v.postDelayed(new Runnable() {
                        @Override
                        public void run() {
                            Intent intent = new Intent(PlayActivity.this, MainActivity.class);
                            startActivity(intent);
                        }
                    }, 1000);

                }
            }
            // if the 2 images do not match, flip them close
            else {
                final View view = v;
                v.postDelayed(new Runnable() {
                    @Override
                    public void run() {
                        flipClose((ImageView) view);
                        flipClose((ImageView) firstView);
                    }
                }, 400);
            }
        }
    }

    /* Flip to show image */
    private void flipOpen(ImageView v, int imageIndex) {
        v.setImageBitmap(bitmaps[imageIndex]);
        v.setTag("open");
    }

    /* Flip image back to question mark */
    private void flipClose(ImageView v) {
        v.setImageResource(R.drawable.question_mark);
        v.setTag("close");
    }

    /* Check if image is already flipped open */
    private boolean isFlippedOpen(View v) {
        return (v.getTag() == "open");
    }

    /* Update score on UI */
    private void updateScore() {
        scoreView.setText(score + "/6 matches");
    }

    /* Shuffle the sequence of the images */
    private void shuffle(int[] arr) {
        Random rnd = new Random();
        int index, temp;
        for (int i = 0; i < arr.length; i++) {
            index = rnd.nextInt(arr.length);
            temp = arr[i];
            arr[i] = arr[index];
            arr[index] = temp;
        }
    }
}
