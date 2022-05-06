using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : MonoBehaviour
{
    [Header("DamageSender")]
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.ColliderSendDamage(collision);
    }

    protected virtual void ColliderSendDamage(Collider2D collision)
    {
        DamageReceiver damageReceiver = collision.GetComponent<DamageReceiver>();
        if (damageReceiver == null) return;

        damageReceiver.Receive(this.damage);
    }
}
