using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManageAnimationScript : MonoBehaviour
{
    public static void ManageDeathAnimation(PlayerScript Player)
    {
        if(Player.Health == 0)
        {
            Player.canMove = false;
            Player.transform.GetComponent<CircleCollider2D>().enabled = false;
            Player.transform.GetComponent<Animator>().Play(Tags.PLAYER_DEATH_ANIMATION_TAG);
        }
    }
}
