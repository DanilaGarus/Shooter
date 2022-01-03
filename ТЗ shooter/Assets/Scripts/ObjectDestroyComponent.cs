using UnityEngine;

namespace somespritesV2
{
    public class ObjectDestroyComponent : MonoBehaviour
    {
        [SerializeField] private GameObject _ObjectToDestroy;
        public void Destroy()
        {
            Destroy(_ObjectToDestroy);  
        }
    }
}