using UnityEngine;

public class AgentManager : MonoBehaviour {

    public GameObject[] agents;

    // Use this for initialization
    void Start () {
        agents = GameObject.FindGameObjectsWithTag("AI");
    }
	
    // Update is called once per frame
    void Update () {
        if (agents == null)
        {
            return;
        }
        // 왼쪽 마우스를 누를 경우
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            // 카메라에서 마우스의 위치를 100거리 내의 마우스를 찾아 RaycastHit로 반환합니다. 
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                //
                foreach (GameObject agent in agents)
                    agent.GetComponent<AIControl>().agent.SetDestination(hit.point);
            }
        }
    }
}