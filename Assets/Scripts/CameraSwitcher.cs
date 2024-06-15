using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera camera1; // 첫 번째 카메라
    public Camera camera2; // 두 번째 카메라
    public float switchTime = 2.0f; // 카메라 전환까지의 지연 시간

    void Start()
    {
        camera1.gameObject.SetActive(true); // 첫 번째 카메라 활성화
        camera2.gameObject.SetActive(false); // 두 번째 카메라 비활성화
        StartCoroutine(SwitchCameraAfterDelay());
    }

    IEnumerator SwitchCameraAfterDelay()
    {
        yield return new WaitForSeconds(switchTime); // 지연 시간만큼 대기

        camera1.gameObject.SetActive(false); // 첫 번째 카메라 비활성화
        camera2.gameObject.SetActive(true); // 두 번째 카메라 활성화
        Debug.Log("Camera switched");
    }
}
