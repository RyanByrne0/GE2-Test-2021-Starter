using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody myRb;
    [SerializeField]
    public float force;
    
    void Start()
    {
        myRb = gameObject.GetComponent<Rigidbody>();

        myRb.AddForce(transform.forward * force, ForceMode.Impulse);
    }

    
    void Update()
    {
        
    }
}
