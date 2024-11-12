using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : EnemyTest
{

    protected int damage;

    protected override void Awake()
    {
        base.Awake();
        health = 120;

        GameManager.score += 2;

    }

    protected override void Attack(int amount)
    {
        Debug.Log("Golem attacks!");
            
    }

    void Update()
    {

    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("You took " + amount + " points of damage!");

        //throw new System.NotImplementedException();

    }

}
