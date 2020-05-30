using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int random;
    int length = 4;
    public static int numOfCollect;
    public static int health;
    public static List<int> list = new List<int>();

    private void Awake()
    {
        numOfCollect = 0;
        health = 100;
        list.Clear();
    }

    private void Start()
    {
        GeneratePinCode();
    }

    private void Update()
    {
        if (numOfCollect >= 4)
        {
            Debug.Log("bitti");
        }
        if (health <= 0)
        {
            Debug.Log("FAİL");
        }

        Debug.Log("health" + health);
    }

    void GeneratePinCode()
    {
        list = new List<int>(new int[length]);

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
}