using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour {

    [Header("Attributes")]
    [SerializeField] private int hitPoints = 2;

    private bool isDestroyes = false;

    private void TakeDamage(int dmg) {
        EnemySpawner.onEnemyDestroy.Invoke();
        Destroy(gameObject);
    }
}
