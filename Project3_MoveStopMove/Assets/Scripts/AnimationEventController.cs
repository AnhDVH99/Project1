using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventController : MonoBehaviour
{
    public CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSpawnWeapon()
    {
        characterController.OnSpawnWeapon();
    }

    public void OnFinishAttack()
    {
        characterController.PlayAnimation(CharacterController.AnimationState.Idle);
    }
}
