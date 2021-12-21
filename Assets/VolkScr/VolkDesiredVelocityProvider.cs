using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VolkDesiredVelocityProvider : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField, Range(0, 3)]
    private float weight = 1f;

    public float Weight => weight;

    protected VolkMovement VolkMovement;

    private void Awake()
    {
        VolkMovement = GetComponent<VolkMovement>();
    }

    public abstract Vector3 GetDesiredVelocity();

}
