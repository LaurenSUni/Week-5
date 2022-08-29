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

        if (Input.GetButtonDown("Fire1"))
        {
            //redObj and blueObj should swap their vertical positions but keep their horizontal positions

            Debug.Log("red pos1" + transArray[0].transform.position);
            Debug.Log("blue pos1" + transArray[1].transform.position);

            float redY = transArray[0].transform.position.y;
            float blueY = transArray[1].transform.position.y;

            float redX = transArray[0].transform.position.x;
            float redZ = transArray[0].transform.position.z;
            float blueX = transArray[1].transform.position.x;
            float blueZ = transArray[1].transform.position.z;

            transArray[0].transform.position = new Vector3(redX, blueY, redZ);
            transArray[1].transform.position = new Vector3(blueX, redY, blueZ);

            Debug.Log("red pos2" + transArray[0].transform.position);
            Debug.Log("blue pos2" + transArray[1].transform.position);

        }
    }
}
