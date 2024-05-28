using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Dialogue
{
    public string name;
    [TextArea] public string sentences;
    public Sprite image;
}

public class ChatSystem : MonoBehaviour
{
    [SerializeField] private Dialogue[] dialogues;
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private Button mapButton;
    [SerializeField] private string diaglogueKey;

    public bool isDialogue = false;
    private int cnt = 0;
    private string MAIN = "1_Main";
    private string ECC = "ECC";

    public void ShowDialogue()
    {
        // 대화 시작
        OnOff(true);
        cnt = 0;
        NextDialogue();
    }

    private void OnOff(bool flag)
    {
        dialogueBox.SetActive(flag);
        isDialogue = flag;
    }

    private void NextDialogue()
    {
        Debug.Log(dialogues.Length);
        if (cnt >= dialogues.Length)
        {
            OnOff(false);
            SetChatManager();
            mapButton.gameObject.SetActive(true);
            return;
        }

        nameText.text = dialogues[cnt].name;
        dialogueText.text = dialogues[cnt].sentences;
        image.sprite = dialogues[cnt].image;
        cnt++;
    }

    private void SetChatManager()
    {
        if (SceneManager.GetActiveScene().name == ECC)
        {
            ChatManager.manager.ecc = true;
        }
        else if (SceneManager.GetActiveScene().name == MAIN)
        {
            ChatManager.manager.main = true;
        }
    }

    private bool CheckIsDialogueEnd()
    {
        if (SceneManager.GetActiveScene().name == ECC)
        {
            return ChatManager.manager.ecc;
        }
        else if (SceneManager.GetActiveScene().name == MAIN)
        {
            return ChatManager.manager.main;
        }
        return false;
    }

    private void Update()
    {
        if (isDialogue && Input.GetKeyDown(KeyCode.Space))
        {
            NextDialogue();
        }
    }

   void Start()
    {
        if(CheckIsDialogueEnd())
        {
            dialogueBox.SetActive(false);
            return;
        }
        ShowDialogue();
    }
}
