using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{

    public Text pinCodeText;
    public Text timerText;
    public Text healthText;
    public GameObject nextLevel;
    public GameObject restartLevel;
    public GameObject quit;
    private bool isWorked;
    private int time;


    private void Start()
    {
        nextLevel.SetActive(false);
        restartLevel.SetActive(false);
    }

    private void Update()
    {      
        ShowInGameUI();
    }

    void ShowInGameUI()
    {
        // pinCode generate islemi bir kez yazdırsın diye var
        if (!isWorked)
        {
            pinCodeText.text = ListToText(GameManager.Instance.list);

            isWorked = true;
        }

        
        if (GameManager.Instance.isLevelCompleted)
        {
            nextLevel.SetActive(true);
        }

        if (GameManager.Instance.isDead)
        {
            restartLevel.SetActive(true);
        }

        time = Convert.ToInt32(GameManager.Instance.levelTime);
        timerText.text = time.ToString();

        healthText.text = GameManager.Instance.health.ToString();
    }

    public void NextLevel() // buton icin
    {          
        LevelManager.Instance.CompleteLevel();
    }
    public void RestartLevel() // buton icin
    {      
        LevelManager.Instance.RestartLevel();
    }

    public void GoToMainMenu() // buton icin
    {
        LevelManager.Instance.GoToMainMenu();
    }

    private string ListToText(List<int> list)
    {
        string result = " ";
        foreach (var listMember in list)
        {
            result += listMember.ToString();
        }
        return result;
    }

}