using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : State
{
    public Idle idle;
    public bool isIdle;

    public override State RunState()
    {
        if (isIdle && idle.isPlayerDetected is not true)
        {
            return idle;
        }

        return this;
    }
}
