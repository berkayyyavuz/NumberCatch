using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{


    public Text text;
    private bool isWorked;

    private string ListToText(List<int> list)
    {
        string result = " ";
        foreach (var listMember in list)
        {
            result += listMember.ToString();
        }
        return result;
    }

    private void Update()
    {
        if (!isWorked)
        {
            text.text = ListToText(GameManager.list);
            isWorked = true;
        }

    }
}