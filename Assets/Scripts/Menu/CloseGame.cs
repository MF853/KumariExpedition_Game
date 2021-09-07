using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGame : MonoBehaviour
{
    private void Update() {
        
    }
    public void Exit(){
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
