using System.Collections;
using somespritesV2;
using UnityEngine;
using UnityEngine.Events;

// По сути, скрипты для оружий одинаковы, но настроены по-разному
// По этой причине смысла описывать каждый из них не вижу.

namespace Enemy_folder.Enemy_guns_script
{
    public class EnemyGun2Script : MonoBehaviour
    {
        [SerializeField]  private Cooldown _cooldown;
        [SerializeField] private UnityEvent _action;
        [SerializeField] private float _bulletsCount = 2;
        
        // решил не усложнять и просто пихнуть всё под Cooldown (самописный компонент)
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
    
        // Перезарядку сделал через корутину,ибо так проще
        // выждать некое время перезарядки
        
        private IEnumerator Routine()
        {
            yield return new WaitForSeconds(4f);
            _bulletsCount = 2;
            StopCoroutine(Routine());
        }
    
        // ресетает куллдаун и вызывает метод спавна "пули"
        
        public void Shoot()
        {
            _cooldown.Reset();
            _action.Invoke();
        }
    }
}
