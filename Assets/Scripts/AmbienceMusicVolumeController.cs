using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmbienceMusicVolumeController : MonoBehaviour
{    
    [SerializeField]
    Slider _volumeSlider;
    AudioSource _audioSource;
    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }    
    void Update()
    {
        _audioSource.volume = _volumeSlider.value;
    }
}
