using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click_Cone_Ecc1 : MonoBehaviour
{
    void OnMouseDown()
    {
        // 클릭된 오브젝트가 "cone"일 경우 "AR_ECC1" 신으로 이동
        if (gameObject.name == "Cone")
        {
            SceneManager.LoadScene("AR_ECC1");
        }
    }
}
