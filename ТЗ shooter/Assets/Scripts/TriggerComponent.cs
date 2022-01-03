using System;
using UnityEngine;
using UnityEngine.Events;

namespace somespritesV2
{
    public class TriggerComponent : MonoBehaviour
    {
        [SerializeField] private EnterEvent _action;
        [SerializeField] private string _tag;
        [SerializeField] private LayerMask _layer = ~0;
        
        // Простой триггерный компонент,удобнее использовать,чем писать тоже самое
        // напрямую в скрипте - связал что нужно, и всё работает 

        
        public void OnTriggerEnter(Collider other)
        {
            if (!other.gameObject.IsInLayer(_layer)) return;
            if (!string.IsNullOrEmpty(_tag) && !other.gameObject.CompareTag(_tag)) return;
            
            _action?.Invoke(other.gameObject);
        }
    }

    [Serializable]
    public class EnterEvent : UnityEvent<GameObject>
    {

    }



}