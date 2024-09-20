using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public void ManageScore(int Score)
    {
        PlayerPrefs.SetInt(Tags.SCORE_PLAYER_PREFS_KEY, Score);
        this.gameObject.GetComponent<TextMeshProUGUI>().text = Tags.SCORE_UI_PREFIX + Score;
    }
}
