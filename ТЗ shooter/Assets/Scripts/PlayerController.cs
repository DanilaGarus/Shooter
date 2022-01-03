using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    [SerializeField] private float playerSpeed = 2.0f;
    [SerializeField] private float jumpHeight = 1.0f;
    [SerializeField] private float gravityValue = -9.81f;
    [SerializeField] private GameObject _gun1;
    [SerializeField] private GameObject _gun2;
    [SerializeField] private GameObject _gun3;
    private InputManager inputManager;
    private Transform cameraTransform;
    
    private void Start()
    {
        inputManager = InputManager.Instance;
        controller = GetComponent<CharacterController>();
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 movement = inputManager.GetPlayerMovement();
        Vector3 move = new Vector3(movement.x,0f, movement.y);
        move = cameraTransform.forward * move.z + cameraTransform.right * move.x;
        move.y = 0f;
        controller.Move(move * Time.deltaTime * playerSpeed);
        
        if (inputManager.PlayerJumped() && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

        if (inputManager.PlayerSwitchedGun1())
        {
            _gun1.SetActive(true);
            _gun2.SetActive(false);
            _gun3.SetActive(false);
        }
        
        if (inputManager.PlayerSwitchedGun2())
        {
            _gun1.SetActive(false);
            _gun2.SetActive(true);
            _gun3.SetActive(false);
        }
        
        if (inputManager.PlayerSwitchedGun3())
        {
            _gun1.SetActive(false);
            _gun2.SetActive(false);
            _gun3.SetActive(true);
        }
    }
}
