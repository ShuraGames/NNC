﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LoseGame : MonoBehaviour
{
    [SerializeField]private GameObject loseMenuPanel;
    [SerializeField]private Text lastCountScoreText;

    private void Update() {
        if(PlayerSataticSet.loseGame){
            if(loseMenuPanel != null){
                loseMenuPanel.SetActive(true);
                Time.timeScale = 0;
                lastCountScoreText.text = PlayerSataticSet.ScoreCountSet.ToString();
            }
        } 
        else
        {
            loseMenuPanel.SetActive(false);
        }
    }

    void ExitToMainMenu(){
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    void ScoreTheLvl(){

    }
}
