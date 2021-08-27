using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    private float zPosition;


    private void Awake() {
        zPosition = transform.position.z;
    }
    private void FixedUpdate() {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = new Vector3(smoothPosition.x, smoothPosition.y, zPosition);

    }
    
}
