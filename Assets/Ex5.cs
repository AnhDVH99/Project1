using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5 : MonoBehaviour
{
   Vector3 start = new Vector3(0,0,0);
   Vector3 destination = new Vector3(3,0,0);
   bool isComplete = false;
   void Start()
   {
       this.transform.position = start;
   }
   void Update()
   {
       float step = Time.deltaTime * 2f;
       if (!isComplete)
       {
           this.transform.position = Vector3.MoveTowards(this.transform.position, destination, step);
           if (this.transform.position == destination)
           {
               isComplete = true;
           }
       }
       else
       {
           this.transform.position = Vector3.MoveTowards(this.transform.position, start, step);
           if (this.transform.position == start)
           {
               isComplete = false;
           }
       }

   }
}
