using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex4 : MonoBehaviour
{
    private Vector3 endPosition = new Vector3(5,-2,0);
    private Vector3 startPosition;
    private float desirerdDuration = 3f;
    private float elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }


    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        float percentageComplete = elapsedTime /desirerdDuration;
        transform.position = Vector3.Lerp(startPosition, endPosition, percentageComplete);
      
    }
}


