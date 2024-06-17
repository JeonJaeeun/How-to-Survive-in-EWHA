using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickCone : MonoBehaviour
{
    void OnMouseDown()
    {
        if(gameObject.name == "Cone")
        {
            SetNavigateEnd();
        }
    }

      private void SetNavigateEnd()
      {
        if(SceneManager.GetActiveScene().name == InsideSceneManager.manager.ECC_STARBUCKS)
        {
            InsideSceneManager.manager.starbucks = true;
            SceneManager.LoadScene("AR_ECC1");
        }
        else if(SceneManager.GetActiveScene().name == InsideSceneManager.manager.ECC_STAIRS)
        {
            InsideSceneManager.manager.ecc_stairs = true;
            SceneManager.LoadScene("AR_ECC2");
        }
      }
}