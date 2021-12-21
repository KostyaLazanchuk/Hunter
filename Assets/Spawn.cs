using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject Cam;
    void Start()
    {
        Instantiate(Cam, new Vector3(0, 0, 10), Quaternion.identity);
    }
}
