using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RabbDesiredVelocityProvider : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField, Range(0, 3)]
    private float weight = 1f;

    public float Weight => weight;

    protected RabbitMovement RabbitMovement;

    private void Awake()
    {
        RabbitMovement = GetComponent<RabbitMovement>();
    }

    public abstract Vector3 GetDesiredVelocity();

}
