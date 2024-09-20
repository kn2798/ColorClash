using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButtonScript : MonoBehaviour
{
    GameObject PauseCanvas;

    private void Start()
    {
        PauseCanvas = GameObject.Find(Tags.PAUSE_CANVAS_NAME);
        PauseCanvas.SetActive(false);
    }

    public void ManagePauseMenu()
    {
        Time.timeScale = 0;
        PauseCanvas.SetActive(true);
    }
}
