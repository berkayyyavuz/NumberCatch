using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDifficulty : MonoBehaviour
{

    public float dropNumberTime;
    public float levelTime;

    private void Start()
    {
        dropNumberTime = 3f;
        levelTime = 60f;
    }
}
