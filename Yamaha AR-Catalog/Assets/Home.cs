using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public Text[] textField;
    public GameObject[] models;
    public static string text,engineType,modelName,mileage,enginePower;
    public static string[] color;
    int modelNumber, noOfCol;

    // Start is called before the first frame update
    void Start() { 
         text = PlayerPrefs.GetString("key");
        string[] list = text.Split(',');
        modelNumber = int.Parse(list[0]);
        engineType = list[1];
        modelName = list[2];
        mileage = list[3];
        enginePower = list[4];
        color = new string[int.Parse(list[5])];
        for(int i = 0; i < int.Parse(list[5]); i++)
        {
            color[i] = list[6 + i];
        }
                textField[3].text = modelName;
        models[modelNumber].SetActive(true);
    }
    
    // Update is called once per frame

}
