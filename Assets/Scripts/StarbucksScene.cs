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
    [SerializeField] private GameObject hintModal;
    [SerializeField] private GameObject firstChat;
    [SerializeField] private GameObject secondChat;
    [SerializeField] private ChatSystem chatSystem;
    [SerializeField] private Image stamp;
    private bool isFirstChatStart = false;

    void Start()
    {
        if (ChatManager.manager.starbucks2)
        {
            mapButton.SetActive(true);
            mapAnimator.SetBool("stop", true);
            mapModal.SetActive(false);
            hintModal.SetActive(true);
        }
        else if (InsideSceneManager.manager.CheckIsNavigationEnd())
        {
            coneAnimator.SetBool("stop", true);
            mapButton.SetActive(true);
            mapModal.SetActive(true);
            mapAnimator.SetBool("stop", true);

            // TODO : 미션 성공 여부로 true값 바꾸기
            stampAnimator.SetBool("success", true);

            // 실패일 경우
            if(false) {
                // 1초 뒤에 chatModal 활성화
                Invoke(nameof(ShowChat), 1f);
            }
        }
        else
        {
            coneAnimator.SetBool("stop", false);
        }
    }

    void Update()
    {
        if (ChatManager.manager.starbucks2)
        {
            mapModal.SetActive(false);
            hintModal.SetActive(true);
        }
        else if (InsideSceneManager.manager.CheckIsNavigationEnd() && stampAnimator.GetBool("isEnd"))
        {
            ChangeStampColor();
        }
        else if (InsideSceneManager.manager.CheckIsNavigationEnd())
        {
            firstChat.SetActive(false);
            hintModal.SetActive(false);
        }
        else if (!isFirstChatStart && InsideSceneManager.manager.CheckIsReached())
        {
            isFirstChatStart = true;
            firstChat.SetActive(true);
        }
    }

    private void ChangeStampColor()
    {
        stamp.color = new Color(255f, 255f, 255f, 1f); // 변경할 색상을 설정합니다.

        // 1초 뒤에 chatModal 활성화
        Invoke(nameof(ShowChat), 1f);
    }

    private void ShowChat()
    {
        mapModal.SetActive(false);
        ChatManager.manager.starbucks2 = false;
        secondChat.SetActive(true);
    }

    public void SceneChange(string name)
    {
        SceneManager.LoadScene(name);
    }
}
