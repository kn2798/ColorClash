using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreenManageScript : MonoBehaviour
{
    public GameObject AudioManager;

    private void Start()
    {
        DontDestroyOnLoad(AudioManager);
    }
}
