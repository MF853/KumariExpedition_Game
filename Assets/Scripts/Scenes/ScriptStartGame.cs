using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptStartGame : MonoBehaviour
{
    public Button buttonInicio;
    void Start() 
    {
        Button btn = buttonInicio.GetComponent<Button>();
		btn.onClick.AddListener(LoadLevel);
    }
    static void LoadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
