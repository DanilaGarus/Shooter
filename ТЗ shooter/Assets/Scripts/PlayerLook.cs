using UnityEngine;

public class PlayerLook : MonoBehaviour
{
   [SerializeField] private float sensX = 8f;
   [SerializeField] private float sensY = 0.5f;
   private float mouseX, mouseY;

   private void Update()
   {
      transform.Rotate(Vector2.up,mouseX * Time.deltaTime);
   }

   public void ReceiveInput(Vector2 mouseInput)
   {
      mouseX = mouseInput.x * sensX;
      mouseY = mouseInput.y * sensY;
   }
}
