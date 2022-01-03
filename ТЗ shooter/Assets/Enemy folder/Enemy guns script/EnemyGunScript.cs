using somespritesV2;
using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class EnemyGunScript : MonoBehaviour
{
    [SerializeField]  private Cooldown _EnemyCooldown;
    [SerializeField] private UnityEvent _action;
    [SerializeField] private float _bulletsCount = 8;

    public void Update()
    {
        if (_EnemyCooldown.IsReady && _bulletsCount != 0)
        {
            _bulletsCount -= 1;
            _EnemyCooldown.Reset();
            _action.Invoke(); 
            if (_bulletsCount <= 0)
            {
                StartCoroutine(Routine());
            }
        }
    }
    
    private IEnumerator Routine()
    {
        yield return new WaitForSeconds(2f);
        _bulletsCount = 8;
        StopCoroutine(Routine());
    }
}
