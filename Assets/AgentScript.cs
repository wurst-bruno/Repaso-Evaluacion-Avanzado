using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //si usas navigator si o si necesitas esta engine

public class AgentScript : MonoBehaviour
{

    NavMeshAgent agent;
    [SerializeField] Transform T1destinationtransform;
    [SerializeField] Transform T2destinationtransform;
    [SerializeField] Transform T3destinationtransform;

    public float remainingDistance;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); //accedo al componente
    }

    // Update is called once per frame
    void Update()
    {
        remainingDistance = agent.remainingDistance;
        agent.destination = T1destinationtransform.position;
        //if (Vector3.Distance(transform.position,T1destinationtransform.position) < 3)
        //{
        //    Destroy(gameObject);
        //}
        
    }
}
