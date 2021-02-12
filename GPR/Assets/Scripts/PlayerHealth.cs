using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth = 100;

    void Update()
    {
        if(playerHealth <= 0)
        {
            Die();
        }
    }

    public void TakeDamage()
    {
        playerHealth -= 10;
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
