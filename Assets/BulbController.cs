using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbController : MonoBehaviour
{
    private Animator bulbAnimator;
    public bool bulbOn;

    void Awake()
    {
        bulbAnimator = GameObject.GetComponent<Animator>();
    }
    
    void Start()
    {
        turnOff();
    }

    public void turnOn()
    {
        bulbAnimator.SetBool("On", true);
        bulbOn = true;
    }

    public void turnOff()
    {
        bulbAnimator.SetBool("On", false);
        bulbOn = false;
    }

}
