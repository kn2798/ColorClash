using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerScript : MonoBehaviour
{
    public GameObject[] BallRefrences;
    public GameObject SpawnedBall;

    public Transform LeftBallSpawner;
    public Transform RightBallSpawner;
    public Vector3 BallPosition;

    public bool ShouldSpawnBalls = true;

    public int BallType; // 0: Special, 1: Score1, 2: Score2, 3: Enemy
    public float BallChance;
    public float BallXPosition;

    public float MinBallSpawnInterval = 0.25f;
    public float MaxBallSpawnInterval = 0.5f;
    public float BallSpawnInterval = 1f;

    // Start is called before the first frame update
    void Start()
    {
        LeftBallSpawner = this.transform.Find(Tags.LEFT_BALL_SPAWNER_NAME);
        RightBallSpawner = this.transform.Find(Tags.RIGHT_BALL_SPAWNER_NAME);

        StartCoroutine(SpawnBalls(this));
    }

    IEnumerator SpawnBalls(BallSpawnerScript Spawner)
    {
        while (Spawner.ShouldSpawnBalls)
        {
            yield return new WaitForSeconds(Spawner.BallSpawnInterval);

            Spawner.BallSpawnInterval = Random.Range(this.MinBallSpawnInterval, this.MaxBallSpawnInterval);

            Spawner.SpawnBall(Spawner);
        }
    }

    public void SpawnBall(BallSpawnerScript Spawner)
    {
        Spawner.ManageSpawnedBallType(Spawner);

        Spawner.ManageSpawnedBallXPosition(Spawner);

        Spawner.ManageSpawnedBallInstantiation(Spawner);
    }

    public void ManageSpawnedBallType(BallSpawnerScript Spawner)
    {
        Spawner.BallChance = Random.Range(0f, 100f);

        if (Spawner.BallChance <= 5) Spawner.BallType = 0; // Special: 5% Chance
        else if (Spawner.BallChance <= 40) Spawner.BallType = 1; // Score1: 35% Chance
        else if (Spawner.BallChance <= 60) Spawner.BallType = 2; // Score2: 20% Chance
        else Spawner.BallType = 3; // Enemy: 40% Chance 
    }

    public void ManageSpawnedBallXPosition(BallSpawnerScript Spawner)
    {
        Spawner.BallXPosition = Random.Range(LeftBallSpawner.position.x, RightBallSpawner.position.x);

        Spawner.BallPosition = Spawner.transform.Find(Tags.LEFT_BALL_SPAWNER_NAME).position;
        Spawner.BallPosition[0] = Spawner.BallXPosition;
    }

    public void ManageSpawnedBallInstantiation(BallSpawnerScript Spawner)
    {
        Spawner.SpawnedBall = Instantiate(Spawner.BallRefrences[Spawner.BallType], Spawner.BallPosition, Quaternion.identity);
    }
}
