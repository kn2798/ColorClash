using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameplayButtonManageAudioScript : MonoBehaviour
{
    public static void ManageAudio()
    {
        GameObject.Find(Tags.AUDIO_MANAGER_NAME).transform.Find(Tags.BUTTON_PRESS_SOUND_EFFECT_NAME).GetComponent<AudioSource>().Play();
    }
}
