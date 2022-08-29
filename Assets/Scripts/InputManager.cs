using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Transform[] transArray = new Transform[2];

    // Start is called before the first frame update
    void Start()
    {
        transArray[0] = GameObject.FindWithTag("Red").transform;
        transArray[1] = GameObject.FindWithTag("Blue").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //NO NEW VARIABLES
            //rotate redObj 45 degrees around the z-axis
            transArray[0].transform.Rotate(0, 0, 45);
            //rotate blueObj -45 degrees around the z-axis
            transArray[1].transform.Rotate(0, 0, -45);
            
        }
    }
}
