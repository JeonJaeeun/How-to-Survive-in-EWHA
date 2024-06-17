using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickFlower_ECC2 : MonoBehaviour
{
    public void SceneChange()
    {
        if(SceneManager.GetActiveScene().name == "AR_ECC1")
        {
            SceneManager.LoadScene("inside_ECC_B4");
        }
        else if(SceneManager.GetActiveScene().name == "AR_ECC2")
        {
            SceneManager.LoadScene("inside_ECC");
        }
    }

}
