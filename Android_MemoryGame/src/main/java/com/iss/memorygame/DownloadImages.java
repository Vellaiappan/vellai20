package com.iss.memorygame;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.widget.ImageView;
import android.widget.ProgressBar;
import android.widget.TextView;

import java.io.BufferedInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.lang.ref.WeakReference;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;

public class DownloadImages extends AsyncTask<String, Integer, String[]> {
    private WeakReference<AppCompatActivity> caller;

    private String[] imagePaths = new String[21];
    public DownloadImages(WeakReference<AppCompatActivity> caller) {
        this.caller = caller;
    }

    @Override
    protected String[] doInBackground(String... urls) {
        InputStream input = null;
        OutputStream out = null;
        int readLen = 0;

        try {
            for (int i=1; i<urls.length; i++) {
                URL url = new URL(urls[i]);
                HttpURLConnection connection = (HttpURLConnection) url.openConnection();
                connection.connect();
                input = connection.getInputStream();
                BufferedInputStream bufIn = new BufferedInputStream(input, 2048); // 2048 is the buffer size

                String imagePath = caller.get().getFilesDir() + "/image" + Integer.toString(i) + ".jpg";
                imagePaths[i] = imagePath;
                out = new FileOutputStream(imagePath); // Creates a file output stream to write to the file with the specified name.

                byte[] data = new byte[1024];
                // bufIn.read(data): Reads some number of bytes from the input stream and stores them
                // into the buffer array data. The number of bytes actually read is returned as an integer.
                while ((readLen = bufIn.read(data)) != -1) {
                    // Writes readLen bytes from the data byte array starting at offset 0 to this output stream.
                    out.write(data, 0, readLen);
                }

                input.close();
                out.close();

//                Thread.sleep(500);
                publishProgress(i);
            }
        } catch (MalformedURLException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }

        return imagePaths;
    }

    @Override
    protected void onProgressUpdate(Integer... values) {
        MainActivity parent = (MainActivity) caller.get();

        int i = values[0];

        // convert the image to bitmap
        Bitmap bitmap = BitmapFactory.decodeFile(imagePaths[i]);

        // display the image on screen
        String imageViewId = "image" + i;
        int resId = parent.getResources().getIdentifier(imageViewId, "id", parent.getPackageName());
        ImageView imageView = parent.findViewById(resId);
        imageView.setImageBitmap(bitmap);

        // set OnClickListener on the image
        imageView.setOnClickListener(parent);

        // update progress bar and text
        ProgressBar bar = parent.findViewById(R.id.progressbar1);
        bar.setProgress(i);

        TextView textView = parent.findViewById(R.id.img_loaded);
        textView.setText(Integer.toString(i));
    }
}
