using System;
using UnityEngine;
using UnityEngine.Events;

namespace somespritesV2
{
    public class EnemyTriggerComponent : MonoBehaviour
    {
        [SerializeField] private EnterEvent2 _action;
        [SerializeField] private string _tag;
        [SerializeField] private LayerMask _layer = ~0;

        public void OnTriggerEnter(Collider other)
        {
            if (!other.gameObject.IsInLayer(_layer)) return;
            if (!string.IsNullOrEmpty(_tag) && !other.gameObject.CompareTag(_tag)) return;
            
            _action?.Invoke(other.gameObject);
        }
    }
    
    [Serializable]
    public class EnterEvent2 : UnityEvent<GameObject>
    {

    }
}