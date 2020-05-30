using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NumberGenerator : MonoBehaviour
{
    float RandomX;
    float yValue=6f;
    public GameObject []sprite;
    bool isActive;
    int randomSpriteNumber;

    private void Update()
    {
        if (isActive == false)
        {
            isActive = true;

            StartCoroutine(GenerateNumber());
          
        }
    }
    IEnumerator GenerateNumber()
    {

        yield return new WaitForSeconds(3f);
        RandomX = UnityEngine.Random.Range(-9f, 9f);
        randomSpriteNumber = UnityEngine.Random.Range(0, 10);
        Instantiate(sprite[randomSpriteNumber], new Vector2(RandomX, yValue),Quaternion.identity);
        isActive = false;
    }
  
}
