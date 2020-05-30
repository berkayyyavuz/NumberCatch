using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberControl : MonoBehaviour
{
    private int id;
    public int myID;
    public GameObject gameManager;


    private void Awake()
    {
        id = myID;
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            if (GameManager.list.Contains(myID))
            {
                GameManager.numOfCollect++;
                Debug.Log(GameManager.numOfCollect + " collector");
                gameObject.SetActive(false);

            }
            else
            {
                gameObject.SetActive(false);
                GameManager.health -= 15;
                Debug.Log("-15");
            }
        }

        if (other.gameObject.tag == "Ground")
        {
            if (GameManager.list.Contains(myID))
            {
                gameObject.SetActive(false);
                GameManager.health -= 10;
                Debug.Log("-10");
            }

        }
    }
}