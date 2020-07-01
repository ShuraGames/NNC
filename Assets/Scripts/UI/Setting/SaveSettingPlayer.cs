using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveSettingPlayer : MonoBehaviour
{
    [SerializeField]private Slider musicVolumeSlider;
    [SerializeField]private Slider graphicQualitySlider;

    public void Save(){
        PlayerPrefs.SetFloat("MusicVolume", musicVolumeSlider.value);
        PlayerPrefs.SetFloat("GraphicQuality", graphicQualitySlider.value);
        Debug.Log("Save setting");
    }
}
