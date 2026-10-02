using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject fallingPrefab;
    [SerializeField] private float spawnInterval = 1f;
    [SerializeField] private float spawnHeight = 6f;
    [SerializeField] private float spawnRange = 2f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer = 0f;
            Spawn();
        }
    }
    void Spawn ()
    {
        Vector3 pos = new Vector3(
            Random.Range(-spawnRange, spawnRange),
            spawnHeight,
            Random.Range(-spawnRange, spawnRange));

        GameObject obj = Instantiate(fallingPrefab, pos, Quaternion.identity);
        Destroy(obj, 8f);
    }
}

