using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverState : IState
{
    public GameOverState(){
        Debug.Log("GameOverState constructor");
    }

    public void EnterState()
    {
         Debug.Log("Enter GameOverState ");
    }

    public void ExecuteState()
    {
         Debug.Log("Execute GameOverState");
    }

    public void ExitState()
    {
         Debug.Log("Exit GameOverState");
    }
}
