using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyTouch : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")){
            Destroy(GameObject.FindWithTag("Player"));
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
