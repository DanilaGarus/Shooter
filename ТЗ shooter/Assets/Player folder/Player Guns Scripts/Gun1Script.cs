using System.Collections;
using somespritesV2;
using UnityEngine;
using UnityEngine.Events;

public class Gun1Script : MonoBehaviour
{
    private InputManager inputManager;
    [SerializeField]  private Cooldown _cooldown;
    [SerializeField] private UnityEvent _action;
    [SerializeField] private float _bulletsCount = 15;
    
    private void Start()
    {
        inputManager = InputManager.Instance;
    }

    private void Update()
    {
        if (inputManager.PlayerShooted() && _cooldown.IsReady && _bulletsCount != 0)
        {
            _bulletsCount -= 1;
            Shoot();
        }
        
        if (_bulletsCount <= 0)
        {
           StartCoroutine(Routine());
        }
    }
    
    private IEnumerator Routine()
    {
        yield return new WaitForSeconds(2f);
        _bulletsCount = 15;
        StopCoroutine(Routine());
    }
    
    public void Shoot()
    {
        _cooldown.Reset();
        _action.Invoke();
    }

   


}
