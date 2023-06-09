using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    public GameObject characterObject;
    public List<CharacterController> listEnemy = new List<CharacterController>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer ==  LayerMask.NameToLayer("CHARACTER") && other.gameObject != characterObject)
        {
            CharacterController enemy = other.transform.GetComponent<CharacterController>();
            if (enemy != null && !listEnemy.Contains(enemy))
            {
                listEnemy.Add(enemy);
            }
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("CHARACTER"))
        {
            CharacterController enemy = other.transform.GetComponent<CharacterController>();
            if (enemy != null)
                listEnemy.Remove(enemy);
        }
    }

    public GameObject FindTheEnemy()
    {
        for(int i=0;i<listEnemy.Count;i++)
        {
            if (listEnemy[i] != null && listEnemy[i].gameObject != null)
                return listEnemy[i].gameObject;
        }
        return null;
    }
}
