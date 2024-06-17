using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goback_ECC1 : MonoBehaviour
{
    void OnMouseDown()
    {
        if (gameObject.name == "backBtn")
        {
            SceneManager.LoadScene("inside_ECC_B4");
        }
    }
}
