using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemsSpawner : MonoBehaviour
{
    [SerializeField] private Gem _gem;
    [SerializeField] private Vector2[] _spawnPoints;

    private void Start()
    {
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            Gem newGem = Instantiate(_gem, _spawnPoints[i], Quaternion.identity);
        }
    }
}
