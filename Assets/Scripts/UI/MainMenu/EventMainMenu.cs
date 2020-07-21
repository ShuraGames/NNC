using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EventMainMenu : MonoBehaviour
{

    [SerializeField]private GameObject SettingPlane;
    [SerializeField]private GlobalSetting gS;
    

    public void RunTheFuckingGame()
    {
         SceneManager.LoadScene("Lvl1", LoadSceneMode.Single);
         Time.timeScale = 1f;
         PlayerSataticSet.BallCount = gS.StartBallCount;
         PlayerSataticSet.hitCount = 0;
         PlayerSataticSet.loseGame = false;
         PlayerAttack.TwoCount = false;
         PlayerSataticSet.ScoreCountSet = gS.countScoreDef;
    }

    public void OpenFuckingSetting()
    {
        if(!SettingPlane.activeSelf)
        {
            SettingPlane.SetActive(true);
        }
    }

    public void BackToMainMenu()
    {
        if(SettingPlane.activeSelf)
        {
            SettingPlane.SetActive(false);
        }
    }

    public void ExitTheGame()
    {
        Application.Quit();
    }
}
