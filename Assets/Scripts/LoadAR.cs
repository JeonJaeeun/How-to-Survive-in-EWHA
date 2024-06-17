using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAR : MonoBehaviour
{

    public void SceneChange()
    {
        SceneManager.LoadScene("AR_Hint_ECC1");
    }
}
