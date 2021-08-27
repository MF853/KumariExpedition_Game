using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracaoCaixa : MonoBehaviour
{
    public Rigidbody movingBox;
    public GameObject player;
    public bool isTouching;
    public Vector3 offset;
    
    void Update()
    {   
        if(isTouching == true && Input.GetKey(KeyCode.J))
        {
            movingBox.transform.SetParent(player.transform);
        }

        else
        {
            movingBox.transform.SetParent(null);
        }
    }

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Player")){
            isTouching = true;
        }
    }

    void OnCollisionExit(Collision other) {
        if(other.gameObject.CompareTag("Player")){
            isTouching = false;
        }
    }
}
