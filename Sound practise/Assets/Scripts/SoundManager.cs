using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioMixer audioMixer;

    [SerializeField]
    private AudioMixerSnapshot gameMode;

    [SerializeField]
    private AudioMixerSnapshot menuMode;


    public void SetAmbientVolume(float _volume)
    {
        _volume = (int)(_volume * 100);


        audioMixer.SetFloat("AmbientVolume", _volume);

    }

    public void GameModeOn()
    {
        gameMode.TransitionTo(0.5f);
    }

    public void MenuModeOn()
    {
        menuMode.TransitionTo(0.5f);
    }

}
