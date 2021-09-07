using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDetection : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")){
            Destroy(player);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
