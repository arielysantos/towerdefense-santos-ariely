using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspanw : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private int baseEnemies = 8;
    [SerializeField] private float enemiesPerSecond = 0.5f;
    [SerializeField] private float timeBotweenWaves = 5f;

    private int currentWave = 1;
    private float timeSinceLastSpawn;
    private int enemiesAlive;
    private int enemiesLeftToSpawn;


    private void Start()
    {
        enemiesLeftToSpawn = baseEnemies;
    }
}
