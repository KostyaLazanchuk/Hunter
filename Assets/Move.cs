using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private int dir = 0;

    public float moveSpeed = 10f;

    void Start()
    {
    }

    void Update()
    {
        dir = Random.Range(0, 4);
        switch (dir)
        {
            case 0: transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime); break;
            case 1: transform.Translate(Vector3.down * moveSpeed * Time.deltaTime); break;
            case 2: transform.Translate(Vector3.right * moveSpeed * Time.deltaTime); break;
            case 3: transform.Translate(Vector3.left * moveSpeed * Time.deltaTime); break;
        }
    }
}
