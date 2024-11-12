using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyCounter enemyCounter;

    void OnDestroy()
    {
        if (enemyCounter != null)
        {
            enemyCounter.EnemyDestroyed();
        }
    }
}
