using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneCamera : MonoBehaviour
{
    public Transform visao;
    void Update()
    {
        if(visao.position.y >= 5.85){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        } 
    }
}
