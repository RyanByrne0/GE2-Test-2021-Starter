using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject ball;

    public Transform ballSpawn;

    
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
            ball.GetComponent<BallScript>().force = 0;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            ball.GetComponent<BallScript>().force += 10 * Time.deltaTime;
        }
    }
}
