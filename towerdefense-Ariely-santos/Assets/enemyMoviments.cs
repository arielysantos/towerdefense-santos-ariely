using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMoviments : MonoBehaviour
{

    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2f;

    private Transform target;

    private int pathIndex = 0;


    private void Start()
    {
        target = levelManager.main.path[pathIndex];
    }
    private void Update()
    {
        if (Vector2.Distance(target.position, transform.position) <= 0.1f)
        {
            pathIndex++;

            if (pathIndex == levelManager.main.path.Length)
            {
                EnemySpawner.onEnemyDestroy.Invoke();
                Destroy(gameObject);
                return;
            }
        }
    }

}

