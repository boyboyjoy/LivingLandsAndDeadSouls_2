﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Menu
{
    public class PauseMenu : MonoBehaviour
    {
        public void OnGamePause()
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }

        public void OnGameResume()
        {
            Time.timeScale = 1;
            pausePanel.SetActive(false);
        }

        public void OnGameExit()
        {
            OnGameResume();
            var parameterManager = GameObject.Find("ParametersManager").GetComponent<ParameterManager>();
            parameterManager.precipitation = 1;
            parameterManager.rockValue = 4;
            parameterManager.buildingValue = 8;
            parameterManager.forestValue = 3;
            parameterManager.sizeOfForest = 10;
            parameterManager.characterI = 0;
            parameterManager.hostileCharVal = 92;
            parameterManager.neutralCharVal = 128;
            parameterManager.startSeason = 0;
            SaveLoadSystem.SaveSystem.Save();
            SceneManager.LoadScene("Menu");
        }
        
        //data members
        public GameObject pausePanel;
    }
}//end of namespace Menu
