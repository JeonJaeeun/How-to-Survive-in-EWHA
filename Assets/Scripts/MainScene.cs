using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScene : MonoBehaviour
{
    [SerializeField] private GameObject timetable;
    [SerializeField] private ChatSystem mainChat;

    void Update()
    {
        if (!mainChat.CheckIsNpc())
        {
            timetable.SetActive(true);
        }
        else
        {
            timetable.SetActive(false);
        }
    }
}
