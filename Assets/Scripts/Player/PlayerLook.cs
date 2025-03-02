using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotation = 0f;
    private float yRotation = 0f; // Track horizontal rotation

    public float xSensitivity = 30f;
    public float ySensitivity = 30f;

    void Start()
    {
        // Hide and lock cursor to the center of the screen
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Look(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;

        // Vertical rotation (up/down)
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        // Horizontal rotation (left/right)
        yRotation += (mouseX * Time.deltaTime) * xSensitivity;
        transform.localRotation = Quaternion.Euler(0, yRotation, 0);
    }
}