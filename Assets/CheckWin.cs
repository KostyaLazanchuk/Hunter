using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckWin : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        GameObject[] rabbit = GameObject.FindGameObjectsWithTag("Rabb");
        GameObject[] wolf = GameObject.FindGameObjectsWithTag("Volk");
        GameObject[] lan = GameObject.FindGameObjectsWithTag("Lan");
        int rabbitCount = rabbit.Length;
        int wolfCount = wolf.Length;
        int lanCount = lan.Length;
        if (rabbitCount == 0 && wolfCount == 0 && lanCount == 0)
        {
            SceneManager.LoadScene(2);
        }

    }
}
