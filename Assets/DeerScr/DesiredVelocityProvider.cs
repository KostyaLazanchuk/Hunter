using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DeerDesiredVelocityProvider : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField, Range(0, 3)]
    private float weight = 1f;

    public float Weight => weight;

    protected DeerMovement DeerMovement;

    private void Awake()
    {
        DeerMovement = GetComponent<DeerMovement>();
    }

    public abstract Vector3 GetDesiredVelocity();

}
