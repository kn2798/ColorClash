using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float HorizontalForce = 3;

    void Update()
    {
        PlayerManageMovementScript.ManageMovement(this, HorizontalForce);
    }
}
