using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tags : MonoBehaviour
{
    public static string PLAYER_BALL_TAG = "Player";

    public static string SPECIAL_BALL_TAG = "Special";
    public static string SCORE_1_BALL_TAG = "Score1";
    public static string SCORE_2_BALL_TAG = "Score2";
    public static string ENEMY_BALL_TAG = "Enemy";

    public static string BALL_DESTROYER_TAG = "BallDestroyer";
    public static string GAMEPLAY_CANVAS_TAG = "Canvas";

    public static string HEARTS_TAG = "Hearts";
    public static string HEART_TAG = "Heart";

    public static string HEART_REVIVE_ANIMATION_TAG = "HeartReviveAnimation";
    public static string HEART_POP_ANIMATION_TAG = "HeartPopAnimation";
    public static string HEART_IDLE_ANIMATION_TAG = "HeartIdleAnimation";
    public static string PLAYER_DEATH_ANIMATION_TAG = "PlayerDeathAnimation";

    public static string GAMEPLAY_SCENE_TAG = "GameplayScene";
    public static string MAINMENU_SCENE_TAG = "MainMenuScene";
    public static string DEATH_SCENE_TAG = "DeathScreenScene";

    public static string AUDIO_MANAGER_TAG = "AudioManager";
    
    public static string GAMEPLAY_CANVAS_NAME = "GameplayCanvas";
    public static string PAUSE_CANVAS_NAME = "PauseCanvas";

    public static string SCORE_UI_PREFIX = "Score: ";
    public static string BEST_SCORE_UI_PREFIX = "Best: ";

    public static string SCORE_PLAYER_PREFS_KEY = "Score";
    public static string BEST_SCORE_PLAYER_PREFS_KEY = "BestScore";

    public static string LEFT_BALL_SPAWNER_NAME = "BallSpawnerLeftBoundry";
    public static string RIGHT_BALL_SPAWNER_NAME = "BallSpawnerRightBoundry";

    public static string SCORE_TEXT_NAME = "ScoreText";
    public static string BEST_SCORE_TEXT_NAME = "BestScoreText";

    public static string DONT_DESTROY_ON_LOAD_NAME = "DontDestroyOnLoad";

    public static string AUDIO_MANAGER_NAME = "AudioManager";

    public static string DEATH_MUSIC_NAME = "DeathMusic";
    public static string SCORE_SOUND_EFFECT_NAME = "ScoreSoundEffect";
    public static string HIT_SOUND_EFFECT_NAME = "HitSoundEffect";
    public static string HEAL_SOUND_EFFECT_NAME = "HealSoundEffect";
    public static string BUTTON_PRESS_SOUND_EFFECT_NAME = "ButtonPressSoundEffect";

    public static string HEART_REVIVE_ACTION = "Revive";
    public static string HEART_POP_ACTION = "Pop";
    public static string SCORE_ACTION = "Score";

    public static float HEART_REVIVE_ANIMATION_LENGTH = 0.5f;
    public static float HEART_POP_ANIMATION_LENGTH = 0.333f;
}
