using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogBallScript : MonoBehaviour
{
    public Transform carryPos;
    public GameObject dog;
    public GameObject ball;
    
    void Start()
    {
        dog = GameObject.Find("dogCol");
        carryPos = GameObject.Find("ballAttach").transform;
    }

    
    void Update()
    {
        CheckDog();
    }

    void CheckDog()
    {
        if(dog.GetComponent<DogControlller>().ballIsPickedUp == true)
        {
            transform.position = carryPos.position;
        }
        else { transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z); }
        
       
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DogTarget"))
        {
            dog.GetComponent<DogControlller>().ballIsPickedUp = false;

           
        }
    }
}
