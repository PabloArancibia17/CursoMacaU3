using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBackground : MonoBehaviour
{

    public BoxCollider col;
    Vector3 initialPosition;



    private void Start()
    {
        col = GetComponent<BoxCollider>();
        initialPosition = transform.position;

    }
    // Update is called once per frame
    void Update()
    {
        //if (transform.position.x < col.size.x / 2)----- No utilizo esta linea de código dado que se mezclan posiciones con tamaños
        if(transform.position.x <= transform.position.x - transform.position.x/2)
        {
            transform.position = initialPosition;
        }

       






    }
}
