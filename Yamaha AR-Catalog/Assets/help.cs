using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class help : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string text = PlayerPrefs.GetString("Model");
        GameObject.Find("ola").GetComponent<Text>().text = "Your Text"+text;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
