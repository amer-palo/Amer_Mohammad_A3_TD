using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemy;

    public Transform spawnPoint;

    public TextMeshProUGUI countdownText;

    public float waveCountdown = 5f;
    private float countdown = 2f;

    private int waveNumber = 0;
    void Update ()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = waveCountdown;
        }

        countdown -= Time.deltaTime;

        countdownText.text = Mathf.Round(countdown).ToString();
    }

    IEnumerator SpawnWave ()
    {

        waveNumber++;
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);

        }


    
    }

    void SpawnEnemy()
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }
}
