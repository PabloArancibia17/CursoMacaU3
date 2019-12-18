using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float obstaclesSpeed = 10;

    void Update()
    {
        transform.Translate(obstaclesSpeed * Time.deltaTime * Vector3.left);
    }
}
