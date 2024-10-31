using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class turret : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform turretRotatetionPoint;

    [Header("Attributes")]
    [SerializeField] private float targetingRange = 5f;


    private Transform target;

    private void Update()
    {
        if (target == null)
        {
            FindTarget();
            return;
        }
    }

    RotateTowardsTarget();

    private void FindTarget()
    {
        RaycastHit2D[] hits = Physics2D.CircleCastAll(transform.positon, targetingRange, (Vector2)transform.position, 0f, enemyMask);

        if (hits.Length > 0)
        {
            target = hits[0].transform;
        }
    }

    private void RotateTowardsTarget()
    {
        float angle = Mathf.Deg2Rad Atan2(target.position.y - transform.position.y, target.position.x - transform.position.x) * Mathf.Rad2Deg;
    }

    private void OnDrawGizmosSelected()
    {
        Handles.color = Color.cyan;
        Handles.DrawnireDisc(transform.position, transform.forward, targetingRange);
    }


}
