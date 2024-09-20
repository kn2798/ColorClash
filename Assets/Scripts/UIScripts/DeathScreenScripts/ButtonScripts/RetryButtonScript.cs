using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButtonScript : MonoBehaviour
{
    public void ManageRetry()
    {
        DeathScreenButtonManageAudioScript.ManageAudio();
        SceneManager.LoadScene(Tags.GAMEPLAY_SCENE_TAG);
    }
}
