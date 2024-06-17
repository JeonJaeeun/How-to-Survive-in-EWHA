using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hint_button : MonoBehaviour
{
    public void Click_Hintbutton()
    {
         if (SceneManager.GetActiveScene().name == "GONG")
        {
            SceneManager.LoadScene("AR_Hint_ENG");
        }

        else if (SceneManager.GetActiveScene().name == "Library")
        {
            SceneManager.LoadScene("AR_Hint_Library");
        }
    }

    public void Click_Pathbutton()
    {
        if (SceneManager.GetActiveScene().name == "GONG")
        {
            SceneManager.LoadScene("inside_GONG_ASAN3");
        }

        else if (SceneManager.GetActiveScene().name == "Library")
        {
            SceneManager.LoadScene("inside_Library");
        }
    }
}
