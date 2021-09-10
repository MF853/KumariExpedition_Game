using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCredits : MonoBehaviour
{
    public GameObject credits;
    public bool cOpen;
    private void Start() {
        cOpen = false;   
    }
    private void FixedUpdate() {
        credits.SetActive(cOpen);
    }
    public void OpenCredits(){
        cOpen = true;
    }
    public void CloseCredits(){
        cOpen = false;
    }
}
