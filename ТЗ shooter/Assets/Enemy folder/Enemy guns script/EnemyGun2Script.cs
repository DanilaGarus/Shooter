using System.Collections;
using somespritesV2;
using UnityEngine;
using UnityEngine.Events;

namespace Enemy_folder.Enemy_guns_script
{
    public class EnemyGun2Script : MonoBehaviour
    {
        [SerializeField]  private Cooldown _cooldown;
        [SerializeField] private UnityEvent _action;
        [SerializeField] private float _bulletsCount = 2;
        
        private void Update()
        {
            if (_cooldown.IsReady && _bulletsCount != 0)
            {
                _bulletsCount -= 2;
                Shoot();
            }
        
            if (_bulletsCount <= 0)
            {
                StartCoroutine(Routine());
            }
        }
    
        private IEnumerator Routine()
        {
            yield return new WaitForSeconds(4f);
            _bulletsCount = 2;
            StopCoroutine(Routine());
        }
    
        public void Shoot()
        {
            _cooldown.Reset();
            _action.Invoke();
        }
    }
}
