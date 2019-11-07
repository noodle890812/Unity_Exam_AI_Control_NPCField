using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{

    [Header("對話")]
    public string Say = "安安";
    public float SaySpeed = 0.2f;

    [Header("任務")]
    public bool Complete = false;
    public int Batery, BateryFinish = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
