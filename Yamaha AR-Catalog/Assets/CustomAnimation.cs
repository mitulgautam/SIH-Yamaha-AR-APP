using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomAnimation : MonoBehaviour
{
    private Animator anim;
    private bool clicked = false;
   void Start()
    {
        anim = GetComponent<Animator>();
        anim.speed = 0f;
    }
    public void LeftOut()
    {
        if (!clicked)
        {
            anim.Play("ButtonAnimLeftOut", -1, 0f);
            anim.speed = 1f;
            clicked = true;
        }
    }
    public void LeftIn()
    {
        if (!clicked)
        {
            anim.Play("ButtonAnimLeftIn", -1, 0f);
            anim.speed = 1f;
        }
    }
    public void BottomOut()
    {
        if (!clicked)
        {
            anim.Play("ButtonAnimBottomOut", -1, 0f);
            anim.speed = 1f;
        }
    }
    public void BottomIn()
    {
        if (!clicked)
        {
            anim.Play("ButtonAnimBottonIn", -1, 0f);
            anim.speed = 1f;
        }
    }
}
