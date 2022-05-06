using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageSender : DamageSender
{
    [Header("Enemy")]
    public EnemyCtrl enemyCtrl;

    private void Awake()
    {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }

    protected override void ColliderSendDamage(Collider2D collision)
    {
        base.ColliderSendDamage(collision);
        

        this.enemyCtrl.damageReceiver.Receive(1);
      
    }
}
