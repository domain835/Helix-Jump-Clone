using Assets.Scripts;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody Rigidbody;
    public GameState GameState;
    
    public Platform CurrentPlatform;

    public AudioSource jumpSound;

    public void Bounce()
    {
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
        jumpSound.Play();
    }

    public void Die()
    {
        GameState.OnPlayerDied();
        Rigidbody.velocity = Vector3.zero;
        jumpSound.Play();
    }

    public void ReachedFinish()
    {
        GameState.OnPlayerReachedFinish();
        Rigidbody.velocity = Vector3.zero;
        jumpSound.Play();
    }
}
