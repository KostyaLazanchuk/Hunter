using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadDeer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bullet" || collision.tag == "Volk" || collision.tag == "Death")
        Destroy(gameObject);
    }
}
