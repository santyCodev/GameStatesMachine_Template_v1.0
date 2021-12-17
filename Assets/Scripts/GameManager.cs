using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private StateMachine stateMachine;

    private void Awake() {
        if(instance != null && instance != this) {Destroy(gameObject);}
        else {instance = this;}    
    }

    private void Start(){
        stateMachine = new StateMachine();
        StartMainMenuState();
    }

    public void StartMainMenuState(){
        ChangeAndExecuteState(new MainMenuState());

        StartMainGameState();
    }

    public void StartMainGameState(){
        ChangeAndExecuteState(new MainGameState());        

        StartGameOverState();
    }

    public void StartGameOverState(){
        ChangeAndExecuteState(new GameOverState());
    }

    private void ChangeAndExecuteState(IState state){
        stateMachine.ChangeState(state);
        stateMachine.ExecuteCurrentState();
    }
}
