using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public enum CharacterType 
    {
        Player,
        Enemy,
    }
    public enum AnimationState
    {
        Idle,
        Run,
        Attack,
        Die,
        Win
    }

    [SerializeField] public Animator playerAnimator;
    [SerializeField] public Transform playerModel;
    [SerializeField] public Transform shootTransform;
    [SerializeField] public GameObject weaponObject;

    public AttackController attackController;
    public float speed;    
    public GameObject enemy;
    public CharacterType characterType;
    public AnimationState state;
    public float attackTime = 4f;
    // Start is called before the first frame update


    public virtual void FixedUpdate()
    {
        attackTime -= Time.fixedDeltaTime;
        if (attackTime <= 0f && state == AnimationState.Idle)
        {
            Attack();
        }

        this.Move();
    }

    public virtual void Move()
    {

    }

    void Attack()
    {
        if (attackController.FindTheEnemy() != null)
        {
            attackTime = 4f;
            enemy = attackController.FindTheEnemy();
            this.playerModel.transform.LookAt(attackController.FindTheEnemy().transform);
            PlayAnimation(AnimationState.Attack);
        }
    }

    public void PlayAnimation(AnimationState animState)
    {
        if (playerAnimator == null)
            return;

        state = animState;
        switch (animState)
        {
            case AnimationState.Idle:
                playerAnimator.SetTrigger("isIdle");
                break;
            case AnimationState.Run:
                playerAnimator.SetTrigger("isRun");
                break;
            case AnimationState.Attack:
                playerAnimator.SetTrigger("isAttack");
                break;
            case AnimationState.Die:

                break;
            case AnimationState.Win:

                break;
        }
    }

    public void OnSpawnWeapon()
    {
        // Spawn Object
        GameObject weapon = GameObject.Instantiate(weaponObject, shootTransform);
        weapon.transform.localPosition = Vector3.zero;
        weapon.transform.localEulerAngles = new Vector3(0f, 0f, 180f);
        weapon.transform.parent = null;
        weapon.GetComponent<WeaponController>().parent = this;

        // Shoot must on target
        //LeanTween.move(weapon, enemy.transform, 1f);

        // Shoot must on target
        LeanTween.move(weapon, enemy.transform.position, 1f);
    }
}
