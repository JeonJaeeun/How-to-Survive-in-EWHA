using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickFlower : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼 클릭
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform) // 현재 오브젝트를 클릭한 경우
                {
                    SceneManager.LoadScene("1_Main"); // "Main" 씬으로 전환
                }
            }
        }
    }
}
