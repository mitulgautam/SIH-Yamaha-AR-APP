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
        print(text);
        string[] list = text.Split(',');
        modelNumber = int.Parse(list[0]);
        print(modelNumber);
        engineType = list[1];
        print(engineType);
        modelName = list[2];
        print(modelName);
        mileage = list[3];
        print(mileage);
        enginePower = list[4];
        print(enginePower);
        color = new string[int.Parse(list[5])];
        for(int i = 0; i < int.Parse(list[5]); i++)
        {
            color[i] = list[6 + i];
            print(color[i]);
        }
        models[modelNumber].SetActive(true);
       /* textField[0] = GameObject.Find("LowerThirdEngine").GetComponent<Text>();
        textField[1] = GameObject.Find("LowerThirdFuel").GetComponent<Text>();
        textField[2] = GameObject.Find("LowerThirdEnginePower").GetComponent<Text>();
        textField[3] = GameObject.Find("BikeModelNameLowerThird").GetComponent<Text>();
        textField[4] = GameObject.Find("BikeColorAvailableLowerThird").GetComponent<Text>();*/
        textField[0].text = engineType;
        textField[1].text = mileage;
        textField[2].text = enginePower;
        textField[3].text = modelName;
    }
    public void back()
    {
        SceneManager.UnloadSceneAsync(1);
        SceneManager.LoadSceneAsync(0);
    }
    // Update is called once per frame

}
