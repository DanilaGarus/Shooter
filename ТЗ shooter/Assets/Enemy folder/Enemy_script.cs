using UnityEngine;
using UnityEngine.AI;

public class Enemy_script : MonoBehaviour
{
   private NavMeshAgent navMeshAgent;
   PlayerController player;
   [SerializeField] private GameObject _gun1;
   [SerializeField] private GameObject _gun2;
   [SerializeField] private GameObject _gun3;
   
   void Start()
   {
      navMeshAgent = GetComponent<NavMeshAgent>();
      player = FindObjectOfType<PlayerController>();
      navMeshAgent.updateRotation = false;
      
      var gunIndex = Random.Range(1, 4);
      switch (gunIndex)
      {
         case 1:
            _gun1.SetActive(true);
            _gun2.SetActive(false);
            _gun3.SetActive(false);
            break;
         
         case 2:
            _gun1.SetActive(false);
            _gun2.SetActive(true);
            _gun3.SetActive(false);
            break;
         
         case 3:
            _gun1.SetActive(false);
            _gun2.SetActive(false);
            _gun3.SetActive(true);
            break;
      }
   }
   
   void Update()
   {
      navMeshAgent.SetDestination(player.transform.position);
      transform.rotation = Quaternion.LookRotation(navMeshAgent.velocity.normalized);
   }
}
