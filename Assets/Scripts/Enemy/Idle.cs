using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : State
{
    public Chase chase;
    public Idle idle;
    public bool isPlayerDetected;

    [SerializeField] float areaRadius;

    [SerializeField] LayerMask playerLayer;

    void DetectPlayer()
    {
        Collider2D[] playerDetected = Physics2D.OverlapCircleAll(gameObject.transform.position, areaRadius, playerLayer);

        for (int i = 0; i < playerDetected.Length; i++)
        {
            if (playerDetected[i] is not null)
            {
                Debug.Log("Player Detected");
                isPlayerDetected = true;
            }

            else if (playerDetected[i] is null)
            {
                isPlayerDetected = false;
                return;
            }
        }
    }

    private void Update()
    {
        DetectPlayer();
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(gameObject.transform.position, areaRadius);
    }

    public override State RunState()
    {
        if (isPlayerDetected)
        {
            return chase;
        }

        if (!isPlayerDetected)
        {
            return idle;
        }

        return this;
    }
}
