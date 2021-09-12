using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnTelaInicio : MonoBehaviour
{
    public void BackToMenu(){
        SceneManager.LoadScene(1);
    } 
}
