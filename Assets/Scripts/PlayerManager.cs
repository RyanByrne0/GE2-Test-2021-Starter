using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject ball;

    public Transform ballSpawn;

    private float throwForce = 20;
    void Start()
    {
        
    }

    
    void Update()
    {
        ThrowBall();
    }

    void ThrowBall()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(ball, ballSpawn.position, Quaternion.identity);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            ball.GetComponent<BallScript>().force += 5 * Time.deltaTime;
        }
    }
}
