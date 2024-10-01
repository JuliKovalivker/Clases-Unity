using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo3 : MonoBehaviour
{

    public GameObject cubo;
    public float speed = 0.01f;
    public bool right;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (right == true)
        {
            cubo.transform.position += new Vector3(speed, 0f, 0f);
        }
        if (right == false)
        {
            cubo.transform.position -= new Vector3(speed, 0f, 0f);
        }

        if (cubo.transform.position.x <= -8f)
        {
            cubo.transform.position = new Vector3(0f, 0f, 0f);
        }
        if (cubo.transform.position.x >= 8f)
        {
            cubo.transform.position = new Vector3(0f, 0f, 0f);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (right == true)
        {
            right = false;
        }
        else if(right == false)
        {
            right = true;
        }
    }

}
