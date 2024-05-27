using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScene : MonoBehaviour
{
    [SerializeField] private Button mapButton;
    [SerializeField] private GameObject mapPanel;
    private int cnt = 0;

    public void ButtonOnClick()
    {
        cnt++;
        cnt %= 2;
        if (cnt % 2 == 1)
        {
            mapPanel.SetActive(true);
        }
        else
        {
            mapPanel.SetActive(false);
        }
    }
}
