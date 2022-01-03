using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager _instance;
    public static InputManager Instance
    {
        get
        {
            return _instance;
        }
    }
    
    private PlayerControls playerControls;

    private void Awake()
    {
        Cursor.visible = false;
        
        if(_instance != null && _instance != this) Destroy(this.gameObject);
        else
        {
            _instance = this;
        }
        
        playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    public Vector2 GetPlayerMovement()
    {
        return playerControls.Input.Move.ReadValue<Vector2>();
    }
    
    public Vector2 GetMouseDelta()
    {
        return playerControls.Input.Look.ReadValue<Vector2>();
    }

    public bool PlayerJumped()
    {
        return playerControls.Input.Jump.triggered;
    }
    public bool PlayerShooted()
    {
        return playerControls.Input.Shoot.triggered;
    }

    public bool PlayerSwitchedGun1()
    {
        return playerControls.Input.Gun1.triggered;
    }
    
    public bool PlayerSwitchedGun2()
    {
        return playerControls.Input.Gun2.triggered;
    }
    public bool PlayerSwitchedGun3()
    {
        return playerControls.Input.Gun3.triggered;
    }
}