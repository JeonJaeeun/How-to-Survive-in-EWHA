using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

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
    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private Button mapButton;

    private bool isDialogue = false;
    private int cnt = 0;

    public void ShowDialogue()
    {
        // 대화 시작
        OnOff(true);
        cnt = 0;
        NextDialogue();
    }

    private void OnOff(bool flag)
    {
        this.gameObject.SetActive(flag);
        isDialogue = flag;
    }

    private void NextDialogue()
    {
        if (cnt >= dialogues.Length)
        {
            OnOff(false);
            mapButton.gameObject.SetActive(true);
            return;
        }

        nameText.text = dialogues[cnt].name;
        dialogueText.text = dialogues[cnt].sentences;
        image.sprite = dialogues[cnt].image;
        cnt++;
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
        ShowDialogue();
        this.gameObject.SetActive(true);
    }
}
