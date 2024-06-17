using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarbucksScene : MonoBehaviour
{
    [SerializeField] private Animator coneAnimator;
    [SerializeField] private Animator mapAnimator;
    [SerializeField] private GameObject mapButton;
    [SerializeField] private GameObject mapModal;
    
    void Start()
    {
        if(InsideSceneManager.manager.CheckIsNavigationEnd())
        {
            mapButton.SetActive(true);
            mapModal.SetActive(true);
            mapAnimator.SetBool("stop", true);
            coneAnimator.SetBool("stop", true);
        }
        else {
            coneAnimator.SetBool("stop", false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
