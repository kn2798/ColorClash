using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyerScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D BallCollider2D)
    {
        Destroy(BallCollider2D.gameObject);
    }
}
