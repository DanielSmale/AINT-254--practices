using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioMixer audioMixer;


    public void SetAmbientVolume(float _volume)
    {
        _volume = (int)(_volume * 100);


        audioMixer.SetFloat("AmbientVolume", _volume);



    }

}
