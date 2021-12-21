using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flee : DeerDesiredVelocityProvider
{
    [SerializeField]
    private Transform objectToFlee;

    [SerializeField, Range(0, 10)]
    private float arriveRadius;

    public override Vector3 GetDesiredVelocity()
    {
        var distance = (objectToFlee.position - transform.position);
        if (distance.magnitude < arriveRadius)
            return -(objectToFlee.position - transform.position).normalized * DeerMovement.VelocityLimit;
        else return -(objectToFlee.position - transform.position).normalized * DeerMovement.VelocityLimit * 0;
    }

}
