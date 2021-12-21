using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeRabb : RabbDesiredVelocityProvider
{
    [SerializeField]
    private Transform objectToFlee;

    [SerializeField, Range(0, 10)]
    private float arriveRadius;

    public override Vector3 GetDesiredVelocity()
    {
        var distance = (objectToFlee.position - transform.position);
        if (distance.magnitude < arriveRadius)
            return -(objectToFlee.position - transform.position).normalized * RabbitMovement.VelocityLimit;
        else return -(objectToFlee.position - transform.position).normalized * RabbitMovement.VelocityLimit * 0;
    }

}
