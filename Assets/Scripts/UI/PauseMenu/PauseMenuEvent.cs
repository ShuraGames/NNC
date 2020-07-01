using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuEvent : MonoBehaviour
{

    [SerializeField]private GameObject pauseMenuPanel; 
    [SerializeField]private GlobalSetting gS;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(!pauseMenuPanel.activeSelf){
                OpenPauseMenu();
            } 
            else
            {
                ClosePauseMenu();
            }
        }
    }

    public void OpenPauseMenu(){
        if(!pauseMenuPanel.activeSelf){
            Time.timeScale = 0f;
            pauseMenuPanel.SetActive(true);
        }
    }

    public void ClosePauseMenu(){
        if(pauseMenuPanel.activeSelf){
            pauseMenuPanel.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void BackToMainMenu(){
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void Reverse(){
        SceneManager.LoadScene("Lvl1");
        PlayerSataticSet.BallCount = gS.StartBallCount;
        PlayerSataticSet.hitCount = 0;
        PlayerSataticSet.loseGame = false;
        PlayerSataticSet.ScoreCountSet = gS.countScoreDef;
        Time.timeScale = 1f;
    }

    public void ExitAndSave(){
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        gS.maxScoreCount += PlayerSataticSet.ScoreCountSet;
        PlayerPrefs.SetInt("MaxCount", gS.maxScoreCount);
        Debug.Log("Save +" + gS.maxScoreCount);
    }

}
