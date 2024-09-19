using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float HorizontalForce = 7;
    
    public int Score = 0;
    public int BestScore = 0;

    public int Health = 3;
    public int MaxHealth = 3;

    void Update()
    {
        PlayerManageMovementScript.ManageMovement(this, HorizontalForce);
        PlayerManageUIScript.ManageScores(Score);
    }

    private void OnTriggerEnter2D(Collider2D BallCollider2D)
    {
        PlayerManageCollisionScript.ManageCollision(this, BallCollider2D);
    }
}
