using System.Collections;
using somespritesV2;
using UnityEngine;
using UnityEngine.Events;

public class Gun3Script : MonoBehaviour
{
    private InputManager inputManager;
    [SerializeField]  private Cooldown _cooldown;
    [SerializeField] private UnityEvent _action;
    [SerializeField] private float _bulletsCount = 21;

    private void Start()
    {
        inputManager = InputManager.Instance;
    }

    private void Update()
    {
        if (inputManager.PlayerShooted() &&_cooldown.IsReady && _bulletsCount != 0)
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
        yield return new WaitForSeconds(4f);
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
