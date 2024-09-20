using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject AudioManager;

    public float HorizontalForce = 7;
    public float TimeConstantMargin = 0.5f;

    public int Score = 0;
    public int Health = 3;
    public int MaxHealth = 3;

    public bool canMove = true;

    private void Start()
    {
        DontDestroyOnLoad(AudioManager);
    }

    void Update()
    {
        if (canMove)
        {
            PlayerManageMovementScript.ManageMovement(this, HorizontalForce);
        }

        PlayerManageUIScript.ManageScores(Score);

        if(Health == 0)
        {
            StartCoroutine(LoadDeathScreenSceneAfterSeconds(Tags.HEART_POP_ANIMATION_LENGTH + TimeConstantMargin));
        }
    }

    public IEnumerator LoadDeathScreenSceneAfterSeconds(float Seconds)
    {
        yield return new WaitForSeconds(Seconds);
        PlayerManageDeathScript.ManageDeath();
    }

    private void OnTriggerEnter2D(Collider2D BallCollider2D)
    {
        PlayerManageCollisionScript.ManageCollision(this, BallCollider2D);
    }
}
