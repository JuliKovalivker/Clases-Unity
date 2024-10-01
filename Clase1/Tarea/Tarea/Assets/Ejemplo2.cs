using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo2 : MonoBehaviour
{

    public GameObject cubo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cubo.transform.position.y <= -3f)
        {
            cubo.transform.position = new Vector3(0f, 4f, 0f);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        cubo.transform.position = new Vector3(0f, 4f, 0f);
    }
}
