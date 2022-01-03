using UnityEngine;

public class Bullet1Script : MonoBehaviour
{
    private Gun1Script _gunScript;
    private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    private Rigidbody rb;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    //Никакой магии полёта "пули", просто AddForce :)
    
    private void Update()
    {
        _rigidbody.AddForce(_rigidbody.transform.forward * _speed * Time.deltaTime, ForceMode.Impulse);
    }
}
