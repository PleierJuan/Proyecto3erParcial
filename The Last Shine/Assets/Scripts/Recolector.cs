using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Recolector : MonoBehaviour
{
 


    private void Update() 
    {
        AllTesorosCollected();
    }

    

    public void AllTesorosCollected()
    {


        if (transform.childCount == 0) {

            Debug.Log("VICTORIA");
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
           
        }
    
    }

   

}
