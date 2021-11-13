using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour {

    public NavMeshAgent agent;
	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}
}