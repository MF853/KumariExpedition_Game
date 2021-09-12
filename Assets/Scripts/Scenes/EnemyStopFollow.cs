using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyStopFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")){
            enemy.speed = 0f;
        }
    }
}
