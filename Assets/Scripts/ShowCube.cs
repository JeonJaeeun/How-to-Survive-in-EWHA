using UnityEngine;
using Vuforia;

public class ShowCube : MonoBehaviour
{
    private DefaultObserverEventHandler observerEventHandler;
    public GameObject cube;

    void Start()
    {
        observerEventHandler = GetComponent<DefaultObserverEventHandler>();
        if (observerEventHandler)
        {
            observerEventHandler.OnTargetFound.AddListener(OnTargetFound);
            observerEventHandler.OnTargetLost.AddListener(OnTargetLost);
        }
        cube.SetActive(false); // 큐브를 초기에는 보이지 않게 설정
    }

    void OnTargetFound()
    {
        // 이미지 타겟이 감지되었을 때 큐브를 활성화
        cube.SetActive(true);
    }

    void OnTargetLost()
    {
        // 이미지 타겟이 감지되지 않았을 때 큐브를 비활성화
        cube.SetActive(false);
    }
}
