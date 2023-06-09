using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public CharacterController parent;

    private void Start()
    {
        Invoke("SelfDestroy", 1f);
    }

    void SelfDestroy()
    {
        GameObject.Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("CHARACTER"))
        {
            if (other.transform.GetComponent<CharacterController>() && other.transform.GetComponent<CharacterController>() != parent)
            {
                Debug.LogError("OnTriggerEnter : "+other.transform.name);
                GameObject.Destroy(other.transform.gameObject);
            }
        }
            
    }

}
