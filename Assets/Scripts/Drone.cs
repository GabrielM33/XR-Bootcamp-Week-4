using UnityEngine;
using UnityEngine.AI;

public class Drone : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //player = FindObjectOfType().transform;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);
    }
}
