using UnityEngine;
using UnityEngine.InputSystem;

public class Player_script : MonoBehaviour
{
    [SerializeField] private float sensX = 8f;
    [SerializeField] private float sensY = 0.5f;
    [SerializeField] private float _speed;
    private float mouseX, mouseY;
    private Vector2 Direction;
    private Vector2 mouseDirection;

    //скрипт игрока, в котором происходит применение обработанного ввода мыши
    // можно менять чувствительность мыши
    
    public void OnMove(InputAction.CallbackContext context)
    {
        Direction = context.ReadValue<Vector2>();   
    }

    public void Move(Vector2 direction)
    {
        float scaledMoveSpeed = _speed * Time.deltaTime;
            
        Vector3 moveDirection = new Vector3(direction.x, 0, direction.y);
        transform.position += moveDirection * scaledMoveSpeed;
    }
        
    public void ReceiveInput(Vector2 mouseInput)
    {
        mouseX = mouseInput.x * sensX;
        mouseY = mouseInput.y * sensY;
    }
    private void Update()
    {
        Move(Direction);
        transform.Rotate(Vector2.up,mouseX * Time.deltaTime);
    }
        
}