using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float torqueValue = 1f;
    float speed = 1;
    //bool isMove = false;
    float turn;
    
    Rigidbody2D myBody;
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    speed = 1;
        //    isMove = true;
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    speed = -1;
        //    isMove = true;

        //}

        if (Input.GetKey(KeyCode.RightArrow))
        {
            myBody.AddTorque(-torqueValue);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myBody.AddTorque(torqueValue);

        }

        //turn = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate()
    {
        //if (isMove)
        //{
        //    Move(speed);
        //}
        //turn = Input.GetAxis("Horizontal");
        //myBody.AddForce(/*transform.up*/ new Vector3 (1,0,0) * turn * torqueValue);
    }

    //void Move(float speed)
    //{
    //    myBody.AddTorque(torqueValue * speed);
    //    isMove = false;
    //    Debug.Log("Move");
    //}

}
