using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BestScoreScript : MonoBehaviour
{
    public int BestScore = 0;

    private void Start()
    {
        BestScore = PlayerPrefs.GetInt(Tags.BEST_SCORE_PLAYER_PREFS_KEY);
    }
    
    public void ManageBestScore(int Score)
    {
        BestScore = Mathf.Max(BestScore, Score);
        PlayerPrefs.SetInt(Tags.BEST_SCORE_PLAYER_PREFS_KEY, BestScore);
        this.GetComponent<TextMeshProUGUI>().text = Tags.BEST_SCORE_UI_PREFIX + BestScore;
    }
}
