using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            print("a");
        }
        if (Input.GetKey("b"))
        {
            print("b");
        }
        if (Input.GetKey("c"))
        {
            print("c");
        }
    }
}
