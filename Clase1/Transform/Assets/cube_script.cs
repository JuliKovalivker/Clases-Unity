using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_script : MonoBehaviour
{
    public GameObject myCube;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello Wold");
        pos = myCube.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //var pos = new Vector3();
        //myCube.transform.position += new Vector3(0.1f, 0f, 0f);
        /*Debug.Log(pos);
        Debug.Log(Input.GetKey(KeyCode.D));
        Debug.Log(Input.GetKey(KeyCode.DownArrow));
        Debug.Log(Input.GetKey(KeyCode.UpArrow));
        Debug.Log(Input.GetKeyDown(KeyCode.UpArrow));
        Debug.Log(Input.GetKeyUp(KeyCode.UpArrow));
        bool down_arrow = Input.GetKey(KeyCode.DownArrow);
        Debug.Log(down_arrow);*/

    }

    private void OnCollisionEnter(Collision col)
    {
        Debug.Log("a");
        myCube.transform.position = new Vector3(0f, 5f, 0f);
    }
}
