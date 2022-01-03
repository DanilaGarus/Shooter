using UnityEngine;

namespace somespritesV2
{
    public class SpawnComponent : MonoBehaviour
    {
        
        // Компонент, который спавнит что-то путём инстанциации префаба

        [SerializeField] private Transform[] _target;
        [SerializeField] private GameObject _prefab;

        [ContextMenu("Spawn")]
        
        public void Spawn()
        {
            var parTrans =  _target[0].transform;
            var instantiate = Instantiate(_prefab, _target[0].position, _target[0].rotation);
            
            var scale = new Vector3(0.3f,0.3f,0.3f);
            instantiate.transform.localScale = scale;
            instantiate.SetActive(true);
        }
        
        public void SpawnIn2ndPos()
        {
            var parTrans =  _target[1].transform;
            var instantiate = Instantiate(_prefab, _target[1].position, _target[1].rotation);
            
            var scale = new Vector3(0.3f,0.3f,0.3f);
            instantiate.transform.localScale = scale;
            instantiate.SetActive(true);
        }
        
    }
}

 