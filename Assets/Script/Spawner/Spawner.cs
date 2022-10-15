using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> spawnPrefabs;

    [Header("Cooldown")]
    [SerializeField]
    private float minCooldown;
    [SerializeField]
    private float maxCooldown;

    private bool isSpawnEnabled = false;

    //public void StopSpawner()
    //{
    //    EnableSpawn = false;
    //    StopAllCoroutines();
    //}

    private void Start() {
        StartCoroutine(StartSpawning());
    }

    private IEnumerator StartSpawning()
    {
        isSpawnEnabled = true;
        while (isSpawnEnabled)
        {
            float cooldown = Random.Range(minCooldown, maxCooldown);
            yield return new WaitForSeconds(cooldown);
            Spawn();
        }
    }

    private void Spawn()
    {
        float spawnX = Random.Range(GameController.Instance.XLeftMargin, GameController.Instance.XRightMargin);
        int randomIndex = Random.Range(0, spawnPrefabs.Count);
        Instantiate(spawnPrefabs[randomIndex], new Vector3(spawnX, transform.position.y, transform.position.z), Quaternion.identity);
    }
}
