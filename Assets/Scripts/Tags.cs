using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tags : MonoBehaviour
{
    public static string PLAYER_BALL_TAG = "Player";

    public static string SPECIAL_BALL_TAG = "Special";
    public static string SCORE_1_BALL_TAG = "Score1";
    public static string SCORE_2_BALL_TAG = "Score2";
    public static string ENEMY_BALL_TAG = "Enemy";

    public static string BALL_DESTROYER_TAG = "BallDestroyer";
    public static string CANVAS_TAG = "Canvas";
    
    public static string LEFT_BALL_SPAWNER_NAME = "BallSpawnerLeftBoundry";
    public static string RIGHT_BALL_SPAWNER_NAME = "BallSpawnerRightBoundry";

    public static string SCORE_UI_PREFIX = "Score: ";
    public static string BEST_SCORE_UI_PREFIX = "Best: ";

    public static string BEST_SCORE_PLAYER_PREFS_KEY = "BestScore";

    public static string SCORE_TEXT_NAME = "ScoreText";
    public static string BEST_SCORE_TEXT_NAME = "BestScoreText";
}
