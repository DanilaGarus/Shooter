using UnityEngine;

namespace somespritesV2
{
    public class DamageComponent : MonoBehaviour
    {
        [SerializeField] private int _damage;
        [SerializeField] private int _Poisiondamage;

        public void ApplyDamage(GameObject target)
        {
            var HealthComponent = target.GetComponent<HealthComponent>();

            if (HealthComponent != null)
            {
                HealthComponent.ApplyDamage(_damage);
            }
        }


        public void ApplyElectricityDamage(GameObject target)
        {
            var HealthComponent2 = target.GetComponent<HealthComponent>();

            if (HealthComponent2 != null)
            {
                HealthComponent2.PeriodicDamage();
            }

        }
    }
}

