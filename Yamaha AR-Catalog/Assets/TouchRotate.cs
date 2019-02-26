using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    public float angle;

    void Update()
    {
        if (Input.touches.Length == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            angle = -Input.GetTouch(0).deltaPosition.x+.05f;
            transform.rotation *= Quaternion.AngleAxis(angle, Vector3.up*.01f);
        }
    }
}
