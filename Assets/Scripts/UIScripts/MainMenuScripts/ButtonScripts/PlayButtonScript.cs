using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(Tags.GAMEPLAY_SCENE_TAG);
    }
}