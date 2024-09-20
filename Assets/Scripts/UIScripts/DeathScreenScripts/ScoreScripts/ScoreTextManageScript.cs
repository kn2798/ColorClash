using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreTextManageScript : MonoBehaviour
{
    private void Awake()
    {
        int Score = PlayerPrefs.GetInt(Tags.SCORE_PLAYER_PREFS_KEY);
        this.gameObject.GetComponent<TextMeshProUGUI>().text = Tags.SCORE_UI_PREFIX + Score;
    }
}
