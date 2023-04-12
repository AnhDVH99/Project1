using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex8 : MonoBehaviour
{
    private Vector2 endPosition = new Vector2(5,-2);
    private float time = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
    
        transform.position = Vector2.Lerp(transform.position , endPosition, time);
      
    }
}
