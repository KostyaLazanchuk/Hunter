using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeerMovement : MonoBehaviour
{
    public Vector3 velocity;
    private Vector3 acceleration;
    [SerializeField]
    private float mass = 1;
    [SerializeField, Range(1, 20)]
    private float velocityLimit = 3;
    [SerializeField, Range(1, 20)]
    private float steeringForceLimit = 5;

    private const float Epsilon = 0.01f;

    public float VelocityLimit => velocityLimit;

    public void ApplyForce(Vector3 force)
    {
        force /= mass;
        acceleration += force;
    }

    // Update is called once per frame
    private void Update()
    {
        ApplyFriction();
        ApplySterringForce();
        ApplyForces();

        void ApplyFriction()
        {
            var friction = -velocity.normalized * 0.5f;
            ApplyForce(friction);
        }
        void ApplySterringForce()
        {
            var provider = GetComponent<DeerDesiredVelocityProvider>();
            if (provider == null)
            {
                return;
            }
            var desiredVelocity = provider.GetDesiredVelocity();
            var steeringForce = desiredVelocity - velocity;
            ApplyForce(steeringForce.normalized * steeringForceLimit);
        }
        void ApplyForces()
        {
            velocity += acceleration * Time.deltaTime;
            velocity = Vector3.ClampMagnitude(velocity, velocityLimit);
            if (velocity.magnitude < Epsilon)
            {
                velocity = Vector3.zero;
                return;
            }
            transform.position += velocity * Time.deltaTime;
            acceleration = Vector3.zero;
        }
    }
}
