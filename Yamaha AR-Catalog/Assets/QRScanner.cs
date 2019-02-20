using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using ZXing;
using UnityEngine.UI;


using ZXing.QrCode;
public class QRScanner : MonoBehaviour
{
    String model;
    private WebCamTexture camTexture;
    private Rect screenRect;
    // Start is called before the first frame update
    void Start()
    {
        screenRect = new Rect(600, 100, 800, 800);
        camTexture = new WebCamTexture();
        camTexture.requestedHeight = Screen.height;
        camTexture.requestedWidth = Screen.width;
        if (camTexture != null)
        {
            camTexture.Play();
        }
    }
    public void QR()
    {
        try
        {
            IBarcodeReader barcodeReader = new BarcodeReader();
            // decode the current frame
            var result = barcodeReader.Decode(camTexture.GetPixels32(), camTexture.width, camTexture.height);
            model = result.Text;
            print(model);
            camTexture.Stop();
        }
        catch (Exception ex) { if (model != null) print(model); }
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
            print(model);
        }
        catch (Exception ex) { if (model != null) print(model); }
    }

    public void Des()
    {
        DestroyImmediate(camTexture);
        Camera c = GameObject.Find("Camera").GetComponent<Camera>();
        print("Close");
        c.enabled = false;
    }
    public void DeleteAll()
    {
        GameObject[] GameObjects = (FindObjectsOfType<GameObject>() as GameObject[]);
        for (int i = 0; i < GameObjects.Length; i++)
        {
            Destroy(GameObjects[i]);
        }
    }
}
