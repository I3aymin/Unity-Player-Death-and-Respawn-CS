using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public float jumpTimer = 3.5f;
    public float autoJump = 3.5f;
    public Vector3 startPosition; 

    private void Awake()
    {
        startPosition = transform.position;
    }

    //Checks if the player character has made contact with a spike and sends the information for respawning
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            transform.position = startPosition;
            //LevelManager.instance.Respawn();
        }
    }
}
