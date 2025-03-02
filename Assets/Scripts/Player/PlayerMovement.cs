using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 playerVelocity;
    public float speed = 20f;
    public float gravity = -9.81f;
    public float jumpPower = 3f;
    public float pullForce = -3f;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
  
    }

    public void Move(Vector2 input)
    {
        // 1. Calculate horizontal movement (world space)
        Vector3 horizontalMove = transform.TransformDirection(new Vector3(input.x, 0, input.y)) * speed;

        // 2. Apply gravity
        playerVelocity.y += gravity * Time.deltaTime;

        // 3. Reset vertical velocity if grounded *after* movement
        //    (Now uses post-movement ground check)
        characterController.Move((horizontalMove + playerVelocity) * Time.deltaTime);
        
        // 4. Update ground status IMMEDIATELY after movement
        if (characterController.isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = -2f; // Small downward force for stability
        }
    }
    public void Jump(){
        if(characterController.isGrounded) // the pullForce is just to adjust the feel of the jump
            playerVelocity.y = Mathf.Sqrt(jumpPower * pullForce * gravity);
    }
}