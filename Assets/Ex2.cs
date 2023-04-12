using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    public float speed = 30;
    public Vector3 target = Vector3.zero;
    private Vector3 origin;
    
    // Start is called before the first frame update
    void Start()
    {
        origin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position == target)
        {
            target = origin;
        }
    }
}
