using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Delegate;

public class Delegate : MonoBehaviour
{
    // Start is called before the first frame update

    public delegate int DemoDelegate();

    DemoDelegate demoDelegate;

    void Start()
    {
        demoDelegate = new DemoDelegate(Sum);
        //Debug.Log(Convert.ToInt32( demoDelegate));
        //demoDelegate = new DemoDelegate(Sum) + new DemoDelegate(Arg);
        //Debug.Log(demoDelegate);
        //demoDelegate();
        demoDelegate += Arg;
        demoDelegate += Sum;
        demoDelegate += Sum;
        demoDelegate = Sum;
        demoDelegate();

        //Debug.Log(Sum() + Arg());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int Sum()
    {
        Debug.Log("Sum");
        return 1;
    }

    public int Arg()
    {
        Debug.Log("Arg");
        return 2;
    }
}
