using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogBallScript : MonoBehaviour
{
    public Transform carryPos;
    public GameObject dog;
    
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
    }
}
