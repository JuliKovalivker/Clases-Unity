using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myScript : MonoBehaviour
{

    public GameObject myCube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Colision");
    }
}
