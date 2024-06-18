using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElevatorEnter : MonoBehaviour
{
    public GameObject elevator_left_stop;
    public GameObject elevator_right_stop;
    public GameObject elevator_left_move;
    public GameObject elevator_right_move;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere" && SceneManager.GetActiveScene().name == "inside_GONG_ASAN3")
        {
            elevator_left_stop.SetActive(false);
            elevator_right_stop.SetActive(false);
            elevator_left_move.SetActive(true);
            elevator_right_move.SetActive(true);

            StartCoroutine(LoadSceneAfterDelay("inside_GONG_ASAN1", 2f));
        }

        else if (other.gameObject.name == "Sphere" && SceneManager.GetActiveScene().name == "inside_GONG_ASAN1")
        {
            elevator_left_stop.SetActive(false);
            elevator_right_stop.SetActive(false);
            elevator_left_move.SetActive(true);
            elevator_right_move.SetActive(true);

            StartCoroutine(LoadSceneAfterDelay("inside_GONG_SIN_B2", 2f));
        }
    }

    private IEnumerator LoadSceneAfterDelay(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}
