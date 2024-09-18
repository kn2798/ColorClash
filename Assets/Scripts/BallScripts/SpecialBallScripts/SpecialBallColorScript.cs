using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialBallColorScript : MonoBehaviour
{
    public static void ManageColor(SpecialBallScript Ball)
    {
        Ball.HSV[0] += 0.01f;

        if (Ball.HSV[0] > 1)
        {
            Ball.HSV[0] -= 1;
        }
        
        Ball.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(Ball.HSV[0], Ball.HSV[1], Ball.HSV[2]);
    }
}
