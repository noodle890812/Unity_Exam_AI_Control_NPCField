using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [Header("移動")]
    [Range(0, 5)] public float MoveSpeed ;

    [Header("跳躍")]
    [Range(0, 100)] public float JumpForce;

    float Timer;
    public bool isGround=false;
    Rigidbody MyRig;

    // Start is called before the first frame update
    void Start()
    {
        MyRig = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, 0, MoveSpeed*1, Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, 0, -MoveSpeed * 1, Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(MoveSpeed * 1, 0,0, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-MoveSpeed * 1, 0, 0, Space.Self);
        }
        if (isGround == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Jump();
            }
        }          
    }

    public void Jump()
    {
        MyRig.AddForce(Vector3.up*JumpForce);
        isGround = false;
    }
    void OnCollisionStay(Collision other)
    {
        isGround = true;
    }
}
