using UnityEngine;

public class NavMove : MonoBehaviour {

    public GameObject Target;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        //NavMesh.SetAreaCost(3, 2);
        int layer = NavMesh.GetAreaFromName("path1");
        NavMesh.SetAreaCost(layer, 2);

        GetComponent<NavMeshAgent>().SetDestination(Target.transform.position);
    }

    void Update()
    {
        if (agent.isOnOffMeshLink)
        {
            agent.CompleteOffMeshLink();
        }
    }
}