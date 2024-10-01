using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newCube : MonoBehaviour
{
    public GameObject myCube;
    public float speed;
    public GameObject newCubex;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            myCube.transform.position += new Vector3(speed, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            myCube.transform.position -= new Vector3(speed, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            myCube.transform.position += new Vector3(0f, speed, 0f);
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            myCube.transform.position -= new Vector3(0f, speed, 0f);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        var place = new Vector3(0f, 10f, 0f);
        Instantiate(newCubex);
        Debug.Log("a");
    }
}
