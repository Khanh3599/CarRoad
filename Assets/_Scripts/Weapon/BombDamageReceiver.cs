using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDamageReceiver : DamageReceiver
{
    //[Header("Bomb")]

    public override void Receive(int damage)
    {
        base.Receive(damage);
        if (this.IsDead())
        {
            Destroy(gameObject);
            EffectManager.instance.SpawnVFX("Explosion_A",transform.position,transform.rotation);
        }
    }
}
