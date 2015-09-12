using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerAIController : MonoBehaviour
{
    public Transform m_moveTarget;

	void Start () {
        if (m_moveTarget != null)
            Debug.LogError("Move target must be configured: " + gameObject.name);
        else
            GetComponent<NavMeshAgent>().destination = m_moveTarget.position;

	}
	
	void Update () {
	
	}
}
