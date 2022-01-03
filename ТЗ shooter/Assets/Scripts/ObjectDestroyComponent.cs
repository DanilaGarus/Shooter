using UnityEngine;

namespace somespritesV2
{
    public class ObjectDestroyComponent : MonoBehaviour
    {
        // уж очень я люблю компонентный подход. Дестроит выбранный объект
        // удобно пихать в UnityEvent, тоже на все случаи жизни
        
        [SerializeField] private GameObject _ObjectToDestroy;
        public void Destroy()
        {
            Destroy(_ObjectToDestroy);  
        }
    }
}