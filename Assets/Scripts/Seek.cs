using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Seek : SteeringBehaviour
{
    public GameObject targetGameObject = null;
    public GameObject player;
    public GameObject ball;

    public AudioSource Bark;

    public int audioPlay = 1;

    public Vector3 target = Vector3.zero;

    public void OnDrawGizmos()
    {
        if (isActiveAndEnabled && Application.isPlaying)
        {
            Gizmos.color = Color.cyan;
            if (targetGameObject != null)
            {
                target = targetGameObject.transform.position;
            }
            Gizmos.DrawLine(transform.position, target);
        }
    }

    public override Vector3 Calculate()
    {
        return boid.SeekForce(target);
    }

    public void Update()
    {
        if (targetGameObject != null)
        {
            target = targetGameObject.transform.position;
        }

        LocateBall();
        GoToPlayer();
    }

    public void LocateBall()
    {
        targetGameObject = GameObject.Find("ball(Clone)");
        if (targetGameObject == GameObject.Find("ball(Clone)"))
        {
           //Bark.Play();
            
        }
    }

    public void GoToPlayer()
    {
        if(GameObject.Find("dogCol").GetComponent<DogControlller>().ballIsPickedUp == true || targetGameObject == null)
        {
            targetGameObject = player;
        }
   }
}