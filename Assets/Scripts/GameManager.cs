using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   
    [HideInInspector]public  int health;
    [HideInInspector]public List<int> list = new List<int>();  
    [HideInInspector]public bool isLevelCompleted;
    [HideInInspector]public bool isDead;
    [HideInInspector]public float levelTime;
    public static GameManager Instance;
    public LevelDifficulty levelDifficulty;
    private int random;


    private void Awake()
    {
        Instance = this;
        list.Clear();
        isLevelCompleted = false;
        isDead = false;        
       
        health = 100;
        levelTime = levelDifficulty.levelTime;
    }

    private void Start()
    {
        GeneratePinCode();      
    }

    private void Update()
    {
        DecreaseLevelTime();
       
    }

    // pin code u burada üretiyoruz
    void GeneratePinCode()
    {
        list = new List<int>(new int[4]);

        for (int j = 0; j < 4; j++)
        {
            random = Random.Range(0, 10);

            while (list.Contains(random))
            {
                random = Random.Range(0, 10);
            }

            list[j] = random;
            print(list[j]);

        }
    }

    void DecreaseLevelTime()
    {
        if (health <= 0)
        {
            Debug.Log("LOST");
            isLevelCompleted = false;
            isDead = true;
            health = 0;
        }
        else if (health > 0 && levelTime <= 0)
        {
            Debug.Log("WIN");
            isLevelCompleted = true;
        }


        if (levelTime <= 0)
        {
            levelTime = 0;     
        }
        else
        {
            levelTime -= Time.deltaTime;
        }
       
    }

}