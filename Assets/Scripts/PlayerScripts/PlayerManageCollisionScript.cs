using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManageCollisionScript : MonoBehaviour
{
    public static void ManageCollision(PlayerScript Player, Collider2D BallCollider2D)
    {
        if (BallCollider2D.CompareTag(Tags.SPECIAL_BALL_TAG))
        {
            Player.Health = Mathf.Min(Player.Health + 1, Player.MaxHealth);
        }
        if (BallCollider2D.CompareTag(Tags.SCORE_1_BALL_TAG))
        {
            Player.Score += 1;
        }
        if (BallCollider2D.CompareTag(Tags.SCORE_2_BALL_TAG))
        {
            Player.Score += 2;
        }
        if (BallCollider2D.CompareTag(Tags.ENEMY_BALL_TAG))
        {
            Player.Health -= 1;
        }

        Destroy(BallCollider2D.gameObject);
    }
}
