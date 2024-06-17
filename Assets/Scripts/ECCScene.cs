using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ECCScene : MonoBehaviour
{
  [SerializeField] private Animator mapAnimator;
  [SerializeField] private GameObject modal;
  [SerializeField] private GameObject mapButton;
  [SerializeField] private ChatSystem chatSystem;

  void Update()
  {
      if (!chatSystem.isDialogue)
      {
        modal.SetActive(true);
        mapButton.SetActive(true);
        mapAnimator.SetBool("stop", true);
      }
  }

  public void SceneChange()
  {
      SceneManager.LoadScene("inside_ECC_B4");
  }

    public void SceneChange_AR()
    {
        SceneManager.LoadScene("AR_Hint_ECC1");
    }

    public void SceneChange_ECC()
    {
        SceneManager.LoadScene("ECC");
    }
}
