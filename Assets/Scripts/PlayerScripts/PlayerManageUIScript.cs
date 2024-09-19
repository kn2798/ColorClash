using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using TMPro;
using UnityEngine;

public class PlayerManageUIScript : MonoBehaviour
{
    public static void ManageScores(int Score)
    {
        GameObject.FindWithTag(Tags.CANVAS_TAG).transform.Find(Tags.SCORE_TEXT_NAME).gameObject.GetComponent<ScoreScript>().ManageScore(Score);
        GameObject.FindWithTag(Tags.CANVAS_TAG).transform.Find(Tags.BEST_SCORE_TEXT_NAME).gameObject.GetComponent<BestScoreScript>().ManageBestScore(Score);
    }

    public static void ManageHearts(string Action, int HeartIndex)
    {
        Animator HeartAnimator = GameObject.Find(Tags.CANVAS_TAG).transform.Find(Tags.HEARTS_TAG).Find(Tags.HEART_TAG + HeartIndex).GetComponent<Animator>();

        if(Action == Tags.HEART_REVIVE_ACTION)
        {
            ReviveHeart(HeartAnimator, HeartIndex);
        }
        if(Action == Tags.HEART_POP_ACTION)
        {
            PopHeart(HeartAnimator, HeartIndex);
        }
    }

    public static void ReviveHeart(Animator HeartAnimator, int HeartIndex)
    {
        HeartAnimator.Play(Tags.HEART_REVIVE_ANIMATION_TAG);
    }

    public static void PopHeart(Animator HeartAnimator, int HeartIndex)
    {
        HeartAnimator.Play(Tags.HEART_POP_ANIMATION_TAG);
    }
}
