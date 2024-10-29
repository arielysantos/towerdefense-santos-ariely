using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public class levelManager : MonoBehaviour
    {
        public static levelManager main;

        public Transform startPoint;
        public Transform[] path;

        private void Awake()
        {
            main = this;
        }
    }
}
