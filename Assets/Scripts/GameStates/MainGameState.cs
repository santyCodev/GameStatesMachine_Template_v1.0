using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameState : IState
{
    public MainGameState(){
        Debug.Log("MainGameState constructor");
    }

    public void EnterState()
    {
         Debug.Log("Enter MainGameState ");
    }

    public void ExecuteState()
    {
         Debug.Log("Execute MainGameState");
    }

    public void ExitState()
    {
         Debug.Log("Exit MainGameState");
    }
}
