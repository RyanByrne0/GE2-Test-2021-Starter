using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Seek : SteeringBehaviour
{
    public GameObject targetGameObject = null;
    public GameObject player;

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
    }

    public void GoToPlayer()
    {
        if(GameObject.Find("dogCol").GetComponent<DogControlller>().ballIsPickedUp == true)
        {
            target = new Vector3(player.transform.position.x + 10, 0, player.transform.position.z + 10);
        }
    }
}