using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    [SerializeField]private Slider graphicSettingSlider;
    [SerializeField]private Slider mausicSettingSlider;
    [SerializeField]private Text graphicSettingText;
    [SerializeField]private GlobalSetting globalSetting;
    [SerializeField]private Text maxCountMain;
    [SerializeField]private AudioSource bgSound;

    private void Start() {
        QualitySettings.SetQualityLevel((int)globalSetting.graphicQualityInSetting);
        graphicSettingSlider.value = globalSetting.graphicQualityInSetting;
        maxCountMain.text = globalSetting.maxScoreCountMainMenu.ToString();
        mausicSettingSlider.value = globalSetting.musicVoumeInSetting;
        bgSound.volume = mausicSettingSlider.value;
    }

    public void ChoiseCraphicQuality(){
        QualitySettings.SetQualityLevel((int)graphicSettingSlider.value);

        switch(graphicSettingSlider.value){
            case 0:
                graphicSettingText.text = "Низкая графика";
                break;
            case 1:
                graphicSettingText.text = "Средняя графика";
                break;
            case 2:
                graphicSettingText.text = "Высокая графика";
                break;

        }
    }

    public void ChoiseVolume(){
        bgSound.volume = mausicSettingSlider.value;
    }
}
