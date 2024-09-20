using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManageAudioScript : MonoBehaviour
{
    public static void ManageAudio(PlayerScript Player, string Action)
    {
        if(Action == Tags.HEART_REVIVE_ACTION)
        {
            GameObject.Find(Tags.AUDIO_MANAGER_NAME).transform.Find(Tags.HEAL_SOUND_EFFECT_NAME).GetComponent<AudioSource>().Play();
        }
        if(Action == Tags.HEART_POP_ACTION)
        {
            if(Player.Health == 0)
            {
                GameObject.Find(Tags.AUDIO_MANAGER_NAME).transform.Find(Tags.DEATH_MUSIC_NAME).GetComponent<AudioSource>().Play();
            }
            else
            {
                GameObject.Find(Tags.AUDIO_MANAGER_NAME).transform.Find(Tags.HIT_SOUND_EFFECT_NAME).GetComponent<AudioSource>().Play();
            }
        }
        if (Action == Tags.SCORE_ACTION)
        {
            GameObject.Find(Tags.AUDIO_MANAGER_NAME).transform.Find(Tags.SCORE_SOUND_EFFECT_NAME).GetComponent<AudioSource>().Play();
        }
    }
}
