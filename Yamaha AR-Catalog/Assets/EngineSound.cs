using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EngineSound : MonoBehaviour
{
    public Sprite OffSprite;
    public Sprite OnSprite;
    public Button but;
    public AudioClip[] clips;
    public AudioSource source;
    string text,model;
    private void Start()
    {
         text = PlayerPrefs.GetString("Key");
        string[] list = text.Split(',');
        model = list[0];

    }
    public void ChangeImage()
    {
        if (but.image.sprite == OnSprite)
        {
            but.image.sprite = OffSprite;

            source.Stop();
        }
        else
        {
            but.image.sprite = OnSprite;

            source.PlayOneShot(clips[int.Parse(model)]);
        }
        
    }

}
