using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public State currentState, nextState;

    void RunStateMachine()
    {
        if (currentState is not null)
        {
            nextState = currentState.RunState();
        }

        if (nextState is not null)
        {
            SwitchNextState(nextState);
        }
    }

    void SwitchNextState(State nextState)
    {
        currentState = nextState;
    }

    private void Update()
    {
        RunStateMachine();
    }
}
