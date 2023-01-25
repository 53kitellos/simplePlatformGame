using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemies : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Vector2[] _spawnPoints;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        var spawnTime = new WaitForSeconds(2);

        while (true)
        {
            for (int i = 0; i < _spawnPoints.Length; i++)
            {
                Enemy newEnemy = Instantiate(_enemy, _spawnPoints[i], Quaternion.identity);
                yield return spawnTime;
            }
        }
    }
}