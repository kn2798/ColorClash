using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManageMovementScript : MonoBehaviour
{
    public static float MinPlayerXPosition = -2.3f;
    public static float MaxPlayerXPosition = 2.3f;

    public static void ManageMovement(PlayerScript Player, float HorizontalForce)
    {
        float HorizontalControlMovement = Input.GetAxis("Horizontal");
        float HorizontalMovement = Player.transform.position.x + HorizontalControlMovement * HorizontalForce * Time.deltaTime;
        HorizontalMovement = Mathf.Max(MinPlayerXPosition, Mathf.Min(MaxPlayerXPosition, HorizontalMovement));
        Player.transform.position = new Vector3(HorizontalMovement, Player.transform.position.y);
    }
}
