using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberControl : MonoBehaviour
{
    private int id;
    public int myID;
  
    private void Awake()
    {
        id = myID;     
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            if (GameManager.Instance.list.Contains(myID))
            {
               
                gameObject.SetActive(false);

            }
            else
            {
                gameObject.SetActive(false);
                GameManager.Instance.health -= 15;            
            }
        }

        if (other.gameObject.tag == "Ground")
        {
            if (GameManager.Instance.list.Contains(myID))
            {
                gameObject.SetActive(false);
                GameManager.Instance.health -= 10;              
            }

        }
    }
}