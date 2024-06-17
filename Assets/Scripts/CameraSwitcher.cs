using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public float switchTime = 2.0f;

    void Start()
    {
        camera1.gameObject.SetActive(true);
        camera2.gameObject.SetActive(false);
        StartCoroutine(SwitchCameraAfterDelay());
    }

    IEnumerator SwitchCameraAfterDelay()
    {
        yield return new WaitForSeconds(switchTime);

        camera1.gameObject.SetActive(false);
        camera2.gameObject.SetActive(true);
        Debug.Log("Camera switched");
    }
}
