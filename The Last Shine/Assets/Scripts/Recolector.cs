using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Recolector : MonoBehaviour
{
  

    public void AllTesorosCollected() {

        if (transform.childCount == 1) {

            Debug.Log("VICTORIA");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    
    }
}
