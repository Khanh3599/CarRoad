using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Spawner
{
  //  [Header("Enemy")]
    private void Reset()
    {
        this.spawnPosName = "EnemySpawnPos";    
        this.prefabName = "EnemyPrefab";    
    }
}
