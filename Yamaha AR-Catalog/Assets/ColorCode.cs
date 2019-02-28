using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorCode : MonoBehaviour
{
    public GameObject[] color;
    Color[] c;
    int colpos=5;
    // Start is called before the first frame update
    void Start()
    {
        string text = PlayerPrefs.GetString("key");
        string[] list = text.Split(',');
        c = new Color[int.Parse(list[colpos])];
        for (int i = 0; i < int.Parse(list[colpos]); i++)
        {
            ColorUtility.TryParseHtmlString(list[6+i], out c[i]);
        }
        for (int i = 0; i < int.Parse(list[colpos]); i++)
        { 
             color[i].GetComponent<Image>().color = c[i];   //component example image game object
        }
        for (int i = int.Parse(list[5]); i < 4; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
