using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speedI = 10f;
    public float speedF;
    public float gravity = 2f;
    public float jumpSpeed = 0.5f;
    public CharacterController player;
    public  Vector3 moveDirection;
    private bool crouching;
    private bool running;
    private bool isJumping;
    public Vector3 inputDirection;

    void FixedUpdate()
    {
        MoveAndJump();
        Crouch();
        Run();
        //Speed Adjusment Back to Normal
        if(crouching == false && running == false){
            speedF = speedI;}
    }

    void MoveAndJump()
    {
        //Axis Input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        //Vector for movement
        transform.Rotate(horizontalInput, 0, verticalInput);

        inputDirection = new Vector3(horizontalInput, 0, verticalInput);
        Vector3 transformDirection = transform.TransformDirection(inputDirection);
        Vector3 flatMovement = speedF * Time.deltaTime * transformDirection;
        moveDirection = new Vector3(flatMovement.x, moveDirection.y, flatMovement.z);
        //Jump Adjustments
        if (Input.GetKeyDown(KeyCode.K) && player.isGrounded){   
            moveDirection.y = jumpSpeed;
            isJumping = true;}
        else if (player.isGrounded){
            moveDirection.y = 0f;
            isJumping = false;}
        else{
            moveDirection.y -= gravity * Time.deltaTime;}
        //Move
        player.Move(moveDirection);

    }

    void Crouch(){
        if (Input.GetKey(KeyCode.L) && isJumping == false){ 
            speedF = speedI/2;
            player.transform.localScale = new Vector3(2f, 1.5f, 2f);
            crouching = true;}
        else{
            player.transform.localScale = new Vector3(2f, 2f, 2f);
            crouching = false;}
    }    

    void Run(){
        if(Input.GetKey(KeyCode.I) && crouching == false){
            speedF = speedI * 1.5f;
            running = true;}
        else{
            running = false;}
    }

}
