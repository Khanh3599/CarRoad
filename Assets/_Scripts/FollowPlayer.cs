using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float speed = 27f;
    public float disLimit = 6f;
    public float randPos = 0;


    private void Awake()
    {
        this.player = PlayerCtrl.instance.transform;

        this.randPos = Random.Range(-6, 6);
    }
    void FixedUpdate()
    {
        this.Follow();
    }

    void Follow()
    {
        Vector3 pos = this.player.position;
        pos.x = this.randPos;

        Vector3 distance = pos - transform.position;

        if (distance.magnitude >= this.disLimit)
        {
            Vector3 targetPoint = pos - distance.normalized * this.disLimit;
            transform.position = Vector3.MoveTowards(transform.position, targetPoint, this.speed * Time.fixedDeltaTime);
        }
    }
}
