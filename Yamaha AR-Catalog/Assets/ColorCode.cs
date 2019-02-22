using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorCode : MonoBehaviour
{
    public GameObject[] color;
    Color[] c=new Color[3];
    // Start is called before the first frame update
    void Start()
    {
        string text = PlayerPrefs.GetString("key");
        string[] list = text.Split(',');
        print(list);
        for (int i = 0; i < int.Parse(list[5]); i++)
        {
            ColorUtility.TryParseHtmlString(list[6+i], out c[i]);
            print(c[i]+"");
        }
        for (int i = 0; i < 3; i++)
        { 
             color[i].GetComponent<Image>().color = c[i];
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
