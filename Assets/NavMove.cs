using UnityEngine;

public class NavMove : MonoBehaviour {

    public GameObject Target;

    void Start()
    {
        //NavMesh.SetLayerCost(3, 2);
        int layer = NavMesh.GetNavMeshLayerFromName("path1");
        NavMesh.SetLayerCost(layer, 2);

        GetComponent<NavMeshAgent>().SetDestination(Target.transform.position);
    }
}