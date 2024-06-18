using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InsideSceneManager : MonoBehaviour
{
    public static InsideSceneManager manager;
    public bool starbucks = false;
    public bool ecc_stairs = false;
    public bool gong_b2 = false;
    public bool library = false;

    public bool starbucks_reached = false;
    public bool ecc_stairs_reached = false;
    public bool gong_b2_reached = false;
    public bool library_reached = false;

    public string ECC_STARBUCKS = "inside_ECC_B4";
    public string ECC_STAIRS = "inside_ECC";
    public string GONG_B2F = "inside_GONG_SIN_B2";
    public string LIBRARY = "inside_Library";

    public bool isClicked = false;

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

    public void SetIsReached(bool isReached)
    {
        if (SceneManager.GetActiveScene().name == ECC_STARBUCKS)
        {
            starbucks_reached = isReached;
        }
        else if (SceneManager.GetActiveScene().name == ECC_STAIRS)
        {
            ecc_stairs_reached = isReached;
        }
        else if (SceneManager.GetActiveScene().name == LIBRARY)
        {
            library_reached = isReached;
        }
        else if (SceneManager.GetActiveScene().name == GONG_B2F)
        {
            gong_b2_reached = isReached;
        }
    }

    public bool CheckIsReached()
    {
        if (SceneManager.GetActiveScene().name == ECC_STARBUCKS)
        {
            return starbucks_reached;
        }
        else if (SceneManager.GetActiveScene().name == ECC_STAIRS)
        {
            return ecc_stairs_reached;
        }
        else if (SceneManager.GetActiveScene().name == LIBRARY)
        {
            return library_reached;
        }
        else if (SceneManager.GetActiveScene().name == GONG_B2F)
        {
            return gong_b2_reached;
        }

        return false;
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
        else if (SceneManager.GetActiveScene().name == LIBRARY)
        {
            return library;
        }
        else if (SceneManager.GetActiveScene().name == GONG_B2F)
        {
            return gong_b2;
        }

        return false;
    }
}
