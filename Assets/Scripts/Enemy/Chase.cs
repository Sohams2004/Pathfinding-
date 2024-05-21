using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : State
{
    public Attack attack;
    public bool playerInAttackRange;

    public override State RunState()
    {
        if (playerInAttackRange)
        {
            return attack;
        }

        return this; 
    }
}
