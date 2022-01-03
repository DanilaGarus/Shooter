using System;
using UnityEngine;
using UnityEngine.Events;

namespace somespritesV2
{
    public class EnterCollisionComponent : MonoBehaviour
    {
        [SerializeField] private string _tag;
        [SerializeField] private UnityEvent _action;        

        // тот же триггерный компонент, только для коллизий.
        // коллизии,конечно, мне в ТЗ не понадобились
        
        private void OnCollisionEnter2D(Collision2D other)
        {
          if (other.gameObject.CompareTag(_tag))
            {
                _action?.Invoke(other.gameObject);              
            }
        }

        [Serializable]
        public class UnityEvent : UnityEvent<GameObject>
        {

        }
    }
}