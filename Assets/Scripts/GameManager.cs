using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool isAlive;


    private void Start()
    {
        isAlive = true;
    }

    void Update()
    {
        if (isAlive == false)
        {
            Debug.Log("Game Over");
        }
    }
}
