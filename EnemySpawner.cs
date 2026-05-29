using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float spawnInterval = 1.5f;
    [SerializeField] private float spawnMinX = -7f;
    [SerializeField] private float spawnMaxX = 7f;
    [SerializeField] private float spawnYPosition = 5.5f;

    private float nextSpawnTime;
    private bool isSpawning = true;

    private void OnValidate()
    {
        if (enemyPrefab == null) Debug.LogWarning("Enemy prefab not assigned!");
    }

    private void Update()
    {
        if (!isSpawning) return;

        if (Time.time >= nextSpawnTime)
        {
            SpawnEnemy();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    private void SpawnEnemy()
    {
        if (enemyPrefab == null)
        {
            Debug.LogError("Enemy prefab is not assigned!");
            return;
        }

        float randomX = Random.Range(spawnMinX, spawnMaxX);
        Vector3 spawnPos = new Vector3(randomX, spawnYPosition, 0f);
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }

    public void StopSpawning()
    {
        isSpawning = false;
    }

    public void StartSpawning()
    {
        isSpawning = true;
        nextSpawnTime = Time.time + spawnInterval;
    }
}