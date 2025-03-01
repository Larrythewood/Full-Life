using UnityEngine;

public class InputManager : MonoBehaviour
{
    private InputSystem_Actions inputActions;
    private InputSystem_Actions.PlayerActions playerActions;
    private PlayerMovement playerMovement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        inputActions = new InputSystem_Actions();
        playerActions=inputActions.Player;
        playerMovement = GetComponent<PlayerMovement>();
        playerActions.Jump.performed += ctx => playerMovement.Jump();
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement.Move(playerActions.Move.ReadValue<Vector2>());
    }
    private void OnEnable()
    {
        inputActions.Enable();
    }
    private void OnDisable()
    {
        inputActions.Disable();
    }
}
