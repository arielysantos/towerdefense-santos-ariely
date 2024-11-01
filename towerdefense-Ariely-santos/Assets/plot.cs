using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plot : MonoBehaviour {

    [Header("Rferences")]
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private color hoverColor;

    private GameObject tower;
    private color startColor;

    private void Start() {
        startColor = sr.color;
    }

    private void OnMouseEnter() {
        sr.color = hoverColor;
    }

    private void OnMouseExit() {
        sr.color = startColor;
    }

    private void OnMouseDown() {
        if (tower == null) return;

        GameObject towerToBuild = BuildManager.main.GetSelectedTower();
        tower = Instantiate(towerToBuild, transform.position, Quaternion, identity);
    }
}
