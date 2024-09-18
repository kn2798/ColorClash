using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialBallScript : MonoBehaviour
{
    public Vector3 HSV = new Vector3(0, 1, 1);

    void FixedUpdate()
    {
        SpecialBallColorScript.ManageColor(this);
    }
}
