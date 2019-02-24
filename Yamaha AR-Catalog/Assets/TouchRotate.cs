using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    private Vector2 firstPosition;
    private Vector2 lastPosition;

    void Start()
    {
        Input.simulateMouseWithTouches = true;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            foreach (Touch touch1 in Input.touches)
            {
                if (touch1.phase == TouchPhase.Began)
                {
                    firstPosition = touch1.position;
                    lastPosition = touch1.position;
                }
                if (touch1.phase == TouchPhase.Moved)
                {
                    lastPosition = touch1.position;
                }
                if (touch1.phase == TouchPhase.Ended)
                {

                    if (firstPosition.y - lastPosition.y < -80)
                    {
                        //Up
                    }
                    else
                    {
                        //Down
                    }

                }

            }
        }
}
}
