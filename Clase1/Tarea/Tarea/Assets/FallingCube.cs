using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCube : MonoBehaviour
{
    public GameObject myCube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (myCube.transform.position.y < -10)
        {
            myCube.transform.position = new Vector3(0f, 5f, 0f);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        myCube.transform.position = new Vector3(0f, 5f, 0f);
    }
    }
