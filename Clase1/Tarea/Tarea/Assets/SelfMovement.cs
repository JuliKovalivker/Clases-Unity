using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfMovement : MonoBehaviour
{

    public GameObject myCube;
    public float speed;
    public bool toRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (toRight)
        {
            myCube.transform.position += new Vector3(speed, 0f, 0f);
        }
        else
        {
            myCube.transform.position -= new Vector3(speed, 0f, 0f);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (toRight)
        {
            toRight = false;
        }
        else
        {
            toRight = true;
        }
    }
}
