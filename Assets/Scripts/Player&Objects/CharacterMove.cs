using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController player;
    public Transform cam;
    public float characterSpeed = 2f;
    public Vector3 moveDirection;
    
    void FixedUpdate() {
    float moveX = Input.GetAxis("Horizontal");
    float moveY = Input.GetAxis("Vertical");

    Vector3 moveXScreen = Quaternion.Euler(0f, cam.eulerAngles.y, 0f) * Vector3.forward;
    Vector3 moveYScreen = Quaternion.Euler(0f, cam.eulerAngles.y, 0f) * Vector3.right;

    moveDirection = moveXScreen * moveX + moveYScreen * moveY;
    player.Move(moveDirection * characterSpeed);

     Quaternion characterLookDirection = Quaternion.LookRotation(moveDirection);
     player.transform.rotation = Quaternion.Slerp(player.transform.rotation, characterLookDirection, characterSpeed);
    }
}
