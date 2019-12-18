using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public float limitX = 10;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -limitX)
        {
            Destroy(gameObject);
        }
    }
}
