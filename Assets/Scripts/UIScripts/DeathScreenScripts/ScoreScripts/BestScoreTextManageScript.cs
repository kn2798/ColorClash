using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BestScoreTextManageScript : MonoBehaviour
{
    private void Awake()
    {
        int BestScore = PlayerPrefs.GetInt(Tags.BEST_SCORE_PLAYER_PREFS_KEY);
        this.gameObject.GetComponent<TextMeshProUGUI>().text = Tags.BEST_SCORE_UI_PREFIX + BestScore;
    }
}
