using System.Collections;
using somespritesV2;
using UnityEngine;
using UnityEngine.Events;

namespace Enemy_folder.Enemy_guns_script
{
    public class EnemyGun3Script : MonoBehaviour
    {
        [SerializeField]  private Cooldown _cooldown;
        [SerializeField] private UnityEvent _action;
        [SerializeField] private float _bulletsCount = 21;
        
        private void Update()
        {
            if (_cooldown.IsReady && _bulletsCount != 0)
            {
                _bulletsCount -= 3;
                StartCoroutine(ShootRoutine());
            }
        
            if (_bulletsCount <= 0)
            {
                StartCoroutine(Routine());
            }
        }
    
        private IEnumerator Routine()
        {
            yield return new WaitForSeconds(2f);
            _bulletsCount = 21;
            StopCoroutine(Routine());
        }

        private IEnumerator ShootRoutine()
        {
            _cooldown.Reset();
            _action.Invoke();
            yield return new WaitForSeconds(0.2f);
            _action.Invoke();
            yield return new WaitForSeconds(0.2f);
            _action.Invoke();
        }
    }
}
