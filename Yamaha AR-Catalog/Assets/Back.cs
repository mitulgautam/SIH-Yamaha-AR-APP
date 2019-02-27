using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public string load, unload;
    public void goBack()
    {
        if(unload=="ScanQR")
        new QRScanner().camTexture.Stop();
        SceneManager.UnloadSceneAsync(unload);
        SceneManager.LoadSceneAsync(load);
    }
}
