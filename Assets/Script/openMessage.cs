using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openMessage : MonoBehaviour
{
    public bool switchMessage = false;
    public GameObject canvas2;

    void Start(){
        canvas2.SetActive(false);
    }
    public void openOtherMessage() {
        switchMessage = !switchMessage;
        canvas2.SetActive(switchMessage);
        Debug.Log(switchMessage);
    }
}
