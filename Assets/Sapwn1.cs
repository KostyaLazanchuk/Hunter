using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sapwn1 : MonoBehaviour
{
    [SerializeField] private GameObject Volks;
    [SerializeField] private GameObject Rabbits;
    [SerializeField] private GameObject Lani;
    [SerializeField] private GameObject Player;

    [SerializeField] private Vector2 spawnPosition;

    [SerializeField] private bool random;
    [SerializeField] private int VolkCount;
    [SerializeField] private int RabbCount;
    [SerializeField] private int LaniCount;
    private int playercount=12;
    public void OnSpawnAPrefab()
    {
        for (int i = 0; i < VolkCount; i++)
        {
            float x = Random.Range(-20, 20);
            float y = Random.Range(-11, 11);
            Instantiate(Volks, new Vector2(x, y), Quaternion.identity);
        }
        for (int i = 0; i < RabbCount; i++)
        {
            float x = Random.Range(-20, 20);
            float y = Random.Range(-11, 11);
            Instantiate(Rabbits, new Vector2(x, y), Quaternion.identity);
        }
        for (int i = 0; i < LaniCount; i++)
        {
            float x = Random.Range(-2, 2);
            float y = Random.Range(-2, 2);
            Instantiate(Lani, new Vector2(x, y), Quaternion.identity);
        }
        if (playercount == 1)
        {
            Instantiate(Player, new Vector2(Random.Range(-20, 20), Random.Range(-11, 11)), Quaternion.identity);
            playercount++;
        }
        VolkCount = 0;
        RabbCount = 0;
        LaniCount = 0;
    }

        /*if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }*/

    void Update()
    {
        OnSpawnAPrefab();
    }
}
