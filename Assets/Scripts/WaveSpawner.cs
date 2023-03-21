using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    public float timeBetweenWaves = 5f;
    public TextMeshProUGUI waveCountDownText;

    private float countDown = 2f;
    private int waveindex = 0;
    void Start()
    {
        
    }

    void Update()
    {
        if (countDown <= 0f)
        {
            StartCoroutine(spawnWave());
            countDown = timeBetweenWaves;
        }

        countDown -= Time.deltaTime;

        countDown = Mathf.Clamp(countDown, 0f, Mathf.Infinity);

        waveCountDownText.text = string.Format("{0:00.00}", countDown);
}

    IEnumerator spawnWave()
    {
        waveindex++;
        for (int i = 0; i <waveindex; i++)
        {
            spawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }

    void spawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
