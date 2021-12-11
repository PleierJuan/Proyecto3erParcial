using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EntrarJuego : MonoBehaviour
{
    public Text text;
    public string levelName;
    private bool inDoor = false;



    private void OnTrigger2D(Collider2D collision) {

        if (collision.gameObject.CompareTag("Player")) {

            text.gameObject.SetActive(true);
            inDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        text.gameObject.SetActive(false);
        inDoor = false;
    }
    private void update() {
        if (inDoor && Input.GetKey("e")) {


            SceneManager.LoadScene(levelName);
        }
    
    
    }

}