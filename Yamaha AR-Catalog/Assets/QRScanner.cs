using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using ZXing;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

using ZXing.QrCode;
public class QRScanner : MonoBehaviour
{
    Text text;
    String model;
    public WebCamTexture camTexture;
    private Rect screenRect;
    // Start is called before the first frame update
    void Start()
    {
        screenRect = new Rect(Screen.width/4,Screen.height/4,Screen.width/2,Screen.height/2);
        camTexture = new WebCamTexture();
        camTexture.requestedHeight = Screen.height;
        camTexture.requestedWidth = Screen.width;
        if (camTexture != null)
        {
            camTexture.Play();
        }
        text = GameObject.Find("BikeModelText").GetComponent<Text>();
    }
    public void QR()
    {
        if (text != null && model != null)
        {
            
            try
            {
                PlayerPrefs.SetString("key", model);
                camTexture.Stop();
                SceneManager.LoadSceneAsync("Home");
                
            }
            catch (Exception e)
            {
                print(e);
            }
        }
    }
     public void goBack()
    {
        camTexture.Stop();
        SceneManager.UnloadScene("ScanQR");
        SceneManager.LoadScene("Start");
    }
    void OnGUI()
    {
        // drawing the camera on screen
        GUI.DrawTexture(screenRect, camTexture, ScaleMode.ScaleToFit);
        // do the reading — you might want to attempt to read less often than you draw on the screen for performance sake
        try
        {
            IBarcodeReader barcodeReader = new BarcodeReader();
            // decode the current frame
            var result = barcodeReader.Decode(camTexture.GetPixels32(), camTexture.width, camTexture.height);
            model = result.Text;
            string[] list = model.Split(',');
            text.text = list[2];
        }
        catch (Exception ex) { print(ex.Data); }
    }

}