using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("## Start function ##");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            Debug.Log("Update Input F Pressed");
        }
        if(Input.GetKey(KeyCode.F)){
            Debug.Log("Update Input F");
        }
        if(Input.GetKeyUp(KeyCode.F)){
            Debug.Log("Update Input F released");
        }
        //Debug.Log("@@ Update function @@");
    }
}
