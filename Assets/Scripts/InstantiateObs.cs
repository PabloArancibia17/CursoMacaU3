using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObs : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float delay = 3;
    public float instGenerator = 4;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(InstantiatePrefab), delay, instGenerator);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InstantiatePrefab()
    {
        Instantiate(obstaclePrefab, transform.position, transform.rotation, transform.parent);
    }
}
