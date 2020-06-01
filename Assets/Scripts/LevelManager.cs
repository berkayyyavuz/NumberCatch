using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelManager : MonoBehaviour
{
    public int level;
    public static LevelManager Instance; // singleton
    
    private void Awake()
    {
        Instance = this; 

        level = PlayerPrefs.GetInt("level", 1);

    }
    public void Play() // PLAY BUTONU
    {
        SceneManager.LoadScene(level);
    }

    public void CompleteLevel()
    {

        level++;
        PlayerPrefs.SetInt("level", level);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(level);
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}