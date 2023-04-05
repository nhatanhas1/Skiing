using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    public delegate void testDelegate();
    public event testDelegate EventDemo;
    // Start is called before the first frame update
    void Start()
    {
        testDelegate testDelegate = new testDelegate(Hello);

        if(EventDemo != null)
        {
            EventDemo();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hello()
    {
        Debug.Log("sdfsdf");
    }
}
