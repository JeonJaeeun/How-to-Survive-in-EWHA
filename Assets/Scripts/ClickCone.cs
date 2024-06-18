using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickCone : MonoBehaviour
{
    void OnMouseDown()
    {
        if(gameObject.name == "Cone")
        {
            InsideSceneManager.manager.isClicked = true;
            SetNavigateEnd();
        }
    }

      private void SetNavigateEnd()
      {
        if(SceneManager.GetActiveScene().name == InsideSceneManager.manager.ECC_STARBUCKS)
        {
            SceneManager.LoadScene("AR_ECC1");
        }
        else if(SceneManager.GetActiveScene().name == InsideSceneManager.manager.ECC_STAIRS)
        {
            SceneManager.LoadScene("AR_ECC2");
        }
        else if(SceneManager.GetActiveScene().name == InsideSceneManager.manager.LIBRARY)
        {
            SceneManager.LoadScene("AR_LIBRARY");
        }
        else if (SceneManager.GetActiveScene().name == InsideSceneManager.manager.GONG_B2F)
        {
            SceneManager.LoadScene("AR_ENG");
        }
      }
}