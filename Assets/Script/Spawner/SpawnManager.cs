using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : Singleton<SpawnManager>
{
    [SerializeField]
    private List<Spawner> spawners = new List<Spawner>();

    // Manage spawners here
}
