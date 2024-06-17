using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MapModal : MonoBehaviour
{
    [SerializeField] private GameObject mapPanel;
    [SerializeField] private Animator mapAnimator;
    private bool isClicked = false;

    public void ButtonOnClick()
    {
        mapAnimator.SetBool("stop", true);

        if (!isClicked)
        {
            isClicked = true;
            mapPanel.SetActive(true);
        }
        else
        {
            isClicked = false;
            mapPanel.SetActive(false);
        }
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
