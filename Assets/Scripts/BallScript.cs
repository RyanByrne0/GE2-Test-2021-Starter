using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody myRb;
    public GameObject dogBall;
    public GameObject parent;
   
    public float force;
    
    void Start()
    {
        myRb = gameObject.GetComponent<Rigidbody>();
        myRb.AddForce(transform.forward * force, ForceMode.Impulse);
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dog"))
        {
            Instantiate(dogBall);
            Destroy(this.gameObject);
            other.gameObject.GetComponent<DogControlller>().ballIsPickedUp = true;
            
           
        }
    }

    void Update()
    {
        
    }
}
