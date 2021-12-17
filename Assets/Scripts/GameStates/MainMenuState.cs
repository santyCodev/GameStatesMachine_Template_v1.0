using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuState : IState
{
    public MainMenuState(){
        Debug.Log("MainMenuState constructor");
    }

    public void EnterState()
    {
         Debug.Log("Enter MainMenuState ");
    }

    public void ExecuteState()
    {
         Debug.Log("Execute MainMenuState");
    }

    public void ExitState()
    {
         Debug.Log("Exit MainMenuState");
    }
}
