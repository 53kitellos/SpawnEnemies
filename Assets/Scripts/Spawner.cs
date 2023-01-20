using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            Enemy newEnemy = Instantiate(_enemy, new Vector3(2, 2, 3), Quaternion.identity);

            yield return new WaitForSeconds(2);

            Enemy newEnemy2 = Instantiate(_enemy, new Vector3(-2, 2, 2), Quaternion.identity);

            yield return new WaitForSeconds(2);
        }
    }
}
