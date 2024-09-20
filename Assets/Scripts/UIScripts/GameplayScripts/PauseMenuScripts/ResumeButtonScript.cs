using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButtonScript : MonoBehaviour
{
    GameObject PauseCanvas;

    private void Start()
    {
        PauseCanvas = GameObject.Find(Tags.PAUSE_CANVAS_NAME);
    }

    public void ManageResumeButton()
    {
        Time.timeScale = 1;
        PauseCanvas.SetActive(false);
        GameplayButtonManageAudioScript.ManageAudio();
    }
}
