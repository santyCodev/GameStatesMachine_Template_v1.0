using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine 
{
    public IState currentState;
    public IState previousState;

    public StateMachine(){
        Debug.Log("State Machine Created");
    }

    public void ChangeState(IState state){
        if(currentState != null){
            currentState.ExitState();
        }

        previousState = currentState;
        currentState = state;

        currentState.EnterState();
    }

    public void ExecuteCurrentState(){
        if(currentState != null){
            currentState.ExecuteState();
        }
    }

}
