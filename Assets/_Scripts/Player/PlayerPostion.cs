using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPostion : MonoBehaviour
{
    
    private List<GameObject> minions;
    public GameObject minionPrefab;
    protected float spawnTimer = 0f;
    protected float spawnDelay = 1f;


    private void Start()
    {
        this.minions = new List<GameObject>();
    }
    // Update is called once per frame
    void Update()
    {
        this.Spawn();
       
        this.CheckMinionDead();
    }
     
    private void Spawn()
    {
        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return;
        this.spawnTimer = 0;

        if (this.minions.Count >= 7) return;

        int index = this.minions.Count + 1;
        GameObject minion = Instantiate(this.minionPrefab);
        minion.name = "Bomb #" + index;

        minion.transform.position = transform.position;
        minion.gameObject.SetActive(true);

        this.minions.Add(minion);
    }

    void CheckMinionDead()
    {
        GameObject minion;
        for(int  i = 0; i <this.minions.Count; i++)
        {
            minion = this.minions[i];
            if (minion == null) this.minions.RemoveAt(i);
        }
    }

    
}
