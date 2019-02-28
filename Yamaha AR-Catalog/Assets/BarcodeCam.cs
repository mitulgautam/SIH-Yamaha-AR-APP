using System.Threading;

using UnityEngine;
using UnityEngine.SceneManagement;

using ZXing;
using ZXing.QrCode;


public class BarcodeCam : MonoBehaviour
{
    private WebCamTexture camTexture;
    private Thread qrThread;

    private Color32[] c;
    private int W, H;

    private Rect screenRect;

    private bool isQuit;

    public string ScanResult;

    void OnGUI()
    {
        GUI.DrawTexture(screenRect, camTexture, ScaleMode.ScaleToFit);
        if (ScanResult.Length >10)
        {

            PlayerPrefs.SetString("Key", ScanResult);
            OnDestroy();
            SceneManager.UnloadSceneAsync("ScanQR");
            SceneManager.LoadScene("Home");
        }
    }

    void OnEnable()
    {
        if (camTexture != null)
        {
            camTexture.Play();
            W = camTexture.width;
            H = camTexture.height;
        }
    }

    void OnDisable()
    {
        if (camTexture != null)
        {
            camTexture.Pause();
        }
    }

    void OnDestroy()
    {
        qrThread.Abort();
        camTexture.Stop();
    }

    // It's better to stop the thread by itself rather than abort it.
    void OnApplicationQuit()
    {
        isQuit = true;
    }

    void Start()
    {

        screenRect = new Rect(Screen.width / 4, Screen.height / 4, Screen.width/2, Screen.height/2);

        camTexture = new WebCamTexture();
        camTexture.requestedHeight = Screen.height; // 480;
        camTexture.requestedWidth = Screen.width; //640;
        OnEnable();
        qrThread = new Thread(DecodeQR);
        qrThread.Start();

    }

    void Update()
    {
        if (c == null)
        {
            c = camTexture.GetPixels32();
        }
        print("Update");
    }

    void DecodeQR()
    {
        // create a reader with a custom luminance source
        print("DEcode");
        var barcodeReader = new BarcodeReader { AutoRotate = false, TryHarder = false };

        while (true)
        {
            if (isQuit)
                break;

            try
            {
                // decode the current frame
                var result = barcodeReader.Decode(c, W, H);
                if (result != null)
                {
                    ScanResult = result.Text;
                    print(result.Text+"hello");
                }

                // Sleep a little bit and set the signal to get the next frame
                Thread.Sleep(200);
                c = null;
            }
            catch
            {
            }
        }
    }


}
