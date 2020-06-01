using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpriteGenerator : MonoBehaviour
{
    float RandomX;
    float yValue = 6f;
    public GameObject[] sprite;
    bool isActive;
    int randomSpriteNumber;

    public LevelDifficulty levelDifficulty; // ben levelin kontrolünü bu scriptten kontrol etmek istiyorum

    [HideInInspector]public float dropTime;

    private void Awake()
    {
        dropTime = levelDifficulty.dropNumberTime;
    }

    private void Update()
    {
        // level tamamlanmamıssa ve ölmemissem instantiate et
        if (isActive == false && GameManager.Instance.isLevelCompleted == false && GameManager.Instance.isDead==false)
        {
            isActive = true;
            StartCoroutine(GenerateNumber(dropTime));
        }
    }
    //coroutine 
    IEnumerator GenerateNumber(float dropTime)
    {
        yield return new WaitForSeconds(dropTime);
        RandomX = UnityEngine.Random.Range(-8.7f, 8.7f); // aralıklar
        randomSpriteNumber = UnityEngine.Random.Range(0, 10); // random şekilde
        Instantiate(sprite[randomSpriteNumber], new Vector2(RandomX, yValue), Quaternion.identity); // sayıları üretiyoruz
        isActive = false;
    }

}
