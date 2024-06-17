using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goback : MonoBehaviour
{
    public void Back_button()
    {
        if (SceneManager.GetActiveScene().name == "AR_Hint_ECC1")
        {
            SceneManager.LoadScene("ECC");
        }
        else if (SceneManager.GetActiveScene().name == "AR_Hint_ECC2")
        {
            SceneManager.LoadScene("ECC");
        }
        else if (SceneManager.GetActiveScene().name == "AR_Hint_ENG")
        {
            SceneManager.LoadScene("GONG");
        }

        else if (SceneManager.GetActiveScene().name == "AR_Hint_Library")
        {
            SceneManager.LoadScene("Library");
        }
    }

}
