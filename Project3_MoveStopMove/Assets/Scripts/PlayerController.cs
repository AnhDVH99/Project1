using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : CharacterController
{
    public VariableJoystick variableJoystick;
    public override void Move()
    {
        base.Move();
        // Move
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        transform.position = new Vector3(transform.position.x + speed * direction.x, transform.position.y, transform.position.z + speed * direction.z);
        if (!Mathf.Approximately(variableJoystick.Vertical, 0f) || !Mathf.Approximately(variableJoystick.Horizontal, 0f))
            playerModel.forward = direction;
    }
}
