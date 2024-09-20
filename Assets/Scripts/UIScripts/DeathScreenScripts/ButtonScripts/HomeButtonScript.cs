using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButtonScript : MonoBehaviour
{
    public void ManageHome()
    {
        SceneManager.LoadScene(Tags.MAINMENU_SCENE_TAG);
    }
}
