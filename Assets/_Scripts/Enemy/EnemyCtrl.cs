using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    public Despawner despawner;
    public EnemyDamageReceiver damageReceiver;

    private void Awake()
    {
        this.despawner = GetComponent<Despawner>(); 
        this.damageReceiver = GetComponent<EnemyDamageReceiver>(); 
    }
}
