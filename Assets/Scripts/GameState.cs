using UnityEngine;

public class GameState : MonoBehaviour
{
    public Controls Controls;

    public enum State
    {
        Playing,
        Won,
        Loss,
    }

    public AudioSource bkgMusic;

    public State CurrentState { get; private set; }

    public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Loss;
        Controls.enabled = false;
        Debug.Log("Game Over!");
    }

    public void OnPlayerReachedFinish()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Won;
        Controls.enabled = false;
        Debug.Log("You won!");
    }
}


