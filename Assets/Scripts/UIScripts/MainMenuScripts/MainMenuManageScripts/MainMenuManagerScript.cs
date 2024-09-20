using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManagerScript : MonoBehaviour
{
    public GameObject AudioManager;

    private void Start()
    {
        DontDestroyOnLoad(AudioManager);
    }
}
