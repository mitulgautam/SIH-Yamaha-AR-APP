using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderZoom : MonoBehaviour
{
    public GameObject slider;

    // Update is called once per frame
    float val;
    private void Update()
    {if(val>1.5f)
        transform.localScale = new Vector3(val, val, val);
    }
    public void OnValueChange(float newValue)
    {
        val = newValue;
    }
}
