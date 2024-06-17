using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StarbucksScene : MonoBehaviour
{
    [SerializeField] private Animator coneAnimator;
    [SerializeField] private Animator mapAnimator;
    [SerializeField] private Animator stampAnimator;
    [SerializeField] private GameObject mapButton;
    [SerializeField] private GameObject mapModal;
    [SerializeField] private Image stamp;

    void Start()
    {
        if (InsideSceneManager.manager.CheckIsNavigationEnd())
        {
            mapButton.SetActive(true);
            mapModal.SetActive(true);
            mapAnimator.SetBool("stop", true);
            coneAnimator.SetBool("stop", true);
        }
        else
        {
            coneAnimator.SetBool("stop", false);
        }
    }

    void Update()
    {
        if (stampAnimator.GetBool("isEnd"))
        {
            ChangeStampColor();
        }
    }

    // stampAnimator의 애니메이션 이벤트에서 호출할 함수
    public void ChangeStampColor()
    {
        stamp.color = new Color(255f, 255f, 255f, 1f); // 변경할 색상을 설정합니다.
    }
}
