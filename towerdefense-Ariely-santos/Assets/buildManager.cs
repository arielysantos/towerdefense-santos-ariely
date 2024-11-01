using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildManager : MonoBehaviour
{
   public class BuildManager : MonoBehaviour {
        public static BuildManager main;

        [Header("References")]
        [SerializeFields] private GameObject[] towerPrefabs;

        private int selectedTower = 0;

        private void Awake()  {
            main = this;
        }

        public GameObject GetSelectedTower() {
            return towerPrefabs[selectedTower];
        }
   }
}
