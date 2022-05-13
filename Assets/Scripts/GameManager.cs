using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool gameisOver;
    public GameObject gameoverUI;

    void Start()
    {
        gameisOver = false;
    }
    void Update()
    {
        if (gameisOver)
            return;

      
        if (PlayerStats.Lives <=0)
        {
            EndGame();
        }
    }

    void EndGame ()
    {
        gameisOver = true;
        gameoverUI.SetActive(true);
    }
}
