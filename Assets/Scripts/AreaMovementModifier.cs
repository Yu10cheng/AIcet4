using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AreaMovementModifier : MonoBehaviour
{

private NavMeshAgent _agent;

private float _speed = 10f;
private float _grassspeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
			NavMeshHit hit;
			_agent.SamplePathPosition(-1,0.0f, out hit);
			int GrassMask = 1 << NavMesh.GetAreaFromName("Grass");
			//mask = mask | 1 <<NavMesh.GetAreaFromName("Ice");
			int filtered = hit.mask & GrassMask;
			
			if(filtered == 0)
			{
				_agent.speed = _speed;
			}
			else
			{
				_agent.speed = _grassspeed;
			}
    }

}
