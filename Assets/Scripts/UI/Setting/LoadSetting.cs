using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSetting : MonoBehaviour
{
    [SerializeField]private GlobalSetting globalSetting;

    private void Start() {
        globalSetting.musicVoumeInSetting = PlayerPrefs.GetFloat("MusicVolume", 0.8f);
        globalSetting.graphicQualityInSetting = PlayerPrefs.GetFloat("GraphicQuality", 1);
        globalSetting.maxScoreCountMainMenu = PlayerPrefs.GetInt("MaxCount", 0);
    }
}
