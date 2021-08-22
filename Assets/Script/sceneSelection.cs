using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSelection : MonoBehaviour
{
    public GameObject canvas;
    public bool switchMessage = false;
    void Start(){
        canvas.SetActive(false);
    }
    public void sceneSelected(int scene){
        if(scene == 0){
            SceneManager.LoadScene("Cantina");
        }else if(scene == 1){
            SceneManager.LoadScene("Cube");
        }else if(scene == 2){
            SceneManager.LoadScene("360VideoTour");
        }else if(scene == 3){
            SceneManager.LoadScene("Mezzanine");
        }
    }
    public void openMessage () {
        switchMessage = !switchMessage;
        canvas.SetActive(switchMessage);
    }
}
