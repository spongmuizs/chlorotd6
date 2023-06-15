using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class waveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    public TextMeshProUGUI countDownText;

    public static int waveIndex = 0;

    private void Update()
    {
        if(countdown <= 0f) //If countdown is 0
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime; //Subtract from countdown
        countDownText.text = Mathf.Floor(countdown).ToString();
    }

    IEnumerator SpawnWave() //Spwan new wave of enemies
    {
        waveIndex++;
        moneymanager.turretPrice = moneymanager.turretPrice + (waveIndex * 2);

        enemyMovement.speed = enemyMovement.speed + (waveIndex / 4);
        bullet.speed = bullet.speed + waveIndex * 2;


        for (int i = 0; i < waveIndex; i++)
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
