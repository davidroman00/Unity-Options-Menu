using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmbienceVolumeStaticVariable : MonoBehaviour
{
    public static float AmbienceMusicVolume;
    [SerializeField]
    Slider _volumeSlider;
    void Update()
    {
        AmbienceMusicVolume = _volumeSlider.value;
    }
}
