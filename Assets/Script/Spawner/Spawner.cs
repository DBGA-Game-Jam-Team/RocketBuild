using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> spawnPrefabs;

    [Header("Spawn Range")]
    [SerializeField]
    private Transform leftPoint;
    [SerializeField]
    private Transform rightPoint;

    [Header("Cooldown")]
    [SerializeField]
    private float minCooldown;
    [SerializeField]
    private float maxCooldown;

    private bool _isSpawning = false;

    public void StopSpawner()
    {
        _isSpawning = false;
        StopAllCoroutines();
    }

    public void StartSpawner()
    {
        if(!_isSpawning)
            StartCoroutine(StartSpawning());
    }

    private void Start()
    {
        StartCoroutine(StartSpawning());
    }

    private IEnumerator StartSpawning()
    {
        _isSpawning = true;
        while (true)
        {
            float cooldown = Random.Range(minCooldown, maxCooldown);
            yield return new WaitForSeconds(cooldown);
            Spawn();
        }
    }

    private void Spawn()
    {
        float spawnX = Random.Range(leftPoint.position.x, rightPoint.position.x);
        int randomIndex = Random.Range(0, spawnPrefabs.Count);
        Instantiate(spawnPrefabs[randomIndex], new Vector3(spawnX, transform.position.y, transform.position.z), Quaternion.identity);
    }
}
