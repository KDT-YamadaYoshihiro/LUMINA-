using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;
    private Animator anim;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (!target) return;

        float distance = Vector3.Distance(transform.position, target.position);
        agent.SetDestination(target.position);

        if (distance < 2.5f)
        {
            anim.SetTrigger("Attack");
        }
    }
}
