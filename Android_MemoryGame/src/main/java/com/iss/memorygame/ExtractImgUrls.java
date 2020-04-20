package com.iss.memorygame;

import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.lang.ref.WeakReference;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;

public class ExtractImgUrls extends AsyncTask<String, Integer, String[]> {
    private WeakReference<AppCompatActivity> caller;

    public ExtractImgUrls(WeakReference<AppCompatActivity> caller) {
        this.caller = caller;
    }

    @Override
    protected String[] doInBackground(String... urls) {
        String[] imageUrls = new String[21];
        int numOfImages = 0;

        try {
            // extract html from the URL
            URL url = new URL(urls[0]);
            HttpURLConnection connection = (HttpURLConnection) url.openConnection();
            // to fake that we are a browser so that website will allow this connection
            connection.addRequestProperty("User-Agent","Mozilla/4.76");
            connection.connect();
            InputStream is = connection.getInputStream();
            BufferedReader br = new BufferedReader(new InputStreamReader(is));

            // extract the URLs of the first 20 images
            String line;
            int startIndex, endIndex;
            while ((line = br.readLine()) != null && numOfImages<21) {
                if (line.contains("<img src=")) {
                    startIndex = line.indexOf("<img src=") + 10;
                    endIndex = line.indexOf("\"", startIndex) - 1;
                    imageUrls[numOfImages] = line.substring(startIndex, endIndex+1);
                    numOfImages++;
                }
            }
        } catch(MalformedURLException e){
            e.printStackTrace();
        } catch(IOException e){
            e.printStackTrace();
        }

        return imageUrls;
    }

    @Override
    protected void onPostExecute(String[] imageUrls) {
        MainActivity parent = (MainActivity) caller.get();
        parent.onImageUrlsExtracted(imageUrls);
    }
}
