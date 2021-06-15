using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;

    private void Update()
    {
        if(health <= 0f)
        {
            DestroyEnemy();
        }
    }

    public void TakeDamage(float amount)
    {
        health -= amount; 
    }

    private void DestroyEnemy()
    {
        Destroy(gameObject);
        return;

    }
}
