using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;

public class PlayerManageScoresScript : MonoBehaviour
{
    public static void ManageScores(int Score)
    {
        GameObject.FindWithTag(Tags.CANVAS_TAG).transform.Find(Tags.SCORE_TEXT_NAME).gameObject.GetComponent<ScoreScript>().ManageScore(Score);
        GameObject.FindWithTag(Tags.CANVAS_TAG).transform.Find(Tags.BEST_SCORE_TEXT_NAME).gameObject.GetComponent<BestScoreScript>().ManageBestScore(Score);
    }
}
