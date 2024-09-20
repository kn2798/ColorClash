using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManageDeathScript : MonoBehaviour
{
    public static void ManageDeath()
    {
        SceneManager.LoadScene(Tags.DEATH_SCENE_TAG);
    }
}
