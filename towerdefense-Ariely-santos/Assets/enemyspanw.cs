using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyspanw : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private int baseEnemies = 8;
    [SerializeField] private float enemiesPerSecond = 0.5f;
    [SerializeField] private float timeBotweenWaves = 5f;
    [SerializeField] private float difficultyScalingFactor = 0.75f;

    private int currentWave = 1;
    private float timeSinceLastSpawn;
    private int enemiesAlive;
    private int enemiesLeftToSpawn;
    private bool isSpawning = false;

    private void Update()
    {
        if (!isSpawning) return;

        timeSinceLastSpawn >= (1f / enemiesPerSecond)) 
        {
            Debug.Log("Spawn Enemy");
        }
    }


    private void StartWave()
    {
        isSpawning = true;
        enemiesLeftToSpawn = baseEnemies;
    }

    private int EnemiesPerWave()
    {
        return Mathf.RoundToInt(baseEnemies * Mathf.Pow(currentWave, enemiesPerSecond));
    }
}
