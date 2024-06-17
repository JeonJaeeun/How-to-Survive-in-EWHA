using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InsideSceneManager : MonoBehaviour
{
    public static InsideSceneManager manager;
    public bool starbucks = false;
    public bool ecc_stairs = false;

    public string ECC_STARBUCKS = "inside_ECC_B4";
    public string ECC_STAIRS = "inside_ECC";

    void Awake()
    {
        if(manager == null)
        {
            manager = this;
            starbucks = false;
            ecc_stairs = false;
            DontDestroyOnLoad(this.gameObject);
        }
        else if(manager != this)
        {
            Destroy(this.gameObject);
        }
    }

    public bool CheckIsNavigationEnd()
    {
        if (SceneManager.GetActiveScene().name == ECC_STARBUCKS)
        {
            return starbucks;
        }
        else if (SceneManager.GetActiveScene().name == ECC_STAIRS)
        {
            return ecc_stairs;
        }

        return false;
    }
}
