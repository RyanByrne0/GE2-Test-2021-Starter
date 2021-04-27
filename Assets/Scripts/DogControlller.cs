using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogControlller : MonoBehaviour
{
    public Transform ballAttach;


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            other.transform.position = ballAttach.transform.position;
        }
    }
}
