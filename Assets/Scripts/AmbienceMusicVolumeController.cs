using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmbienceMusicVolumeController : MonoBehaviour
{        
    AudioSource _audioSource;
    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }    
    void Update()
    {
        _audioSource.volume = AmbienceVolumeStaticVariable.AmbienceMusicVolume;
    }
}
