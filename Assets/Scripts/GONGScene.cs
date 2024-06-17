using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GONGScene : MonoBehaviour
{
    [SerializeField] private Animator mapAnimator;
    [SerializeField] private GameObject modal;
    [SerializeField] private ChatSystem chatSystem;

    void Start()
    {
        mapAnimator.SetBool("stop", true);
    }

    void Update()
    {
        if (!chatSystem.isDialogue)
        {
            modal.SetActive(true);
        }
    }

    public void SceneChange()
    {
        SceneManager.LoadScene("inside_ASAN3");
    }

    public void SceneChange_AR()
    {
        SceneManager.LoadScene("AR_ECC");
    }

    public void SceneChange_GONG()
    {
        SceneManager.LoadScene("GONG");
    }
}
