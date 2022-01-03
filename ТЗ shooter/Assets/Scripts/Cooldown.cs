using UnityEngine;

namespace somespritesV2
{
    // Тот самый кулдаун, максимально простой компонент, но очень полезный
    
    public class Cooldown : MonoBehaviour
    {
        [SerializeField] private float _value;

        private float _timesUp;
        
        public void Reset()
        {
            _timesUp = Time.time + _value;
        }

        public bool IsReady => _timesUp <= Time.time;
    }
}
