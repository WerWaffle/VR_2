using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AScript : MonoBehaviour
{
    public GameObject cylinder;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Object is activated");
            cylinder.SetActive(true);
        }

        if (Input.GetKey(KeyCode.H))
        {
            Debug.Log("Object is deactivated");
            cylinder.SetActive(false);
        }
    }
}
