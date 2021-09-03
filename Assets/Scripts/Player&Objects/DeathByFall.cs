using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathByFall : MonoBehaviour
{

    public GameObject player;
    void Update()
    {
        if(player.transform.position.y < -5){
            Destroy(player);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
