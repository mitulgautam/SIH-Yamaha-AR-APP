using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Home : MonoBehaviour
{
    public GameObject[] models;
    string text;

    // Start is called before the first frame update
    void Start()
    {//  models[1] = transform.GetChild(1).gameObject;
     //   models[0].SetActive(false);
      //  models[1].SetActive(false);
         text = PlayerPrefs.GetString("key");
        print(text);
        
    }
    // Update is called once per frame
    void Update()
    {
        models[0].SetActive(true);
    }
}
