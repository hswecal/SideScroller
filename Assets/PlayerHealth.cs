using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 300;
    int currentHealth;

    Vector2 respawnCoords = new Vector2(-7, -3);

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (transform.position.y < -40)
        {
            Respawn();
        }
    }

    // Gör så att man tar damage och dör
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Respawn();
        }
    }

    // Tar bort objektet om man är död
    void Respawn()
    {
        transform.position = respawnCoords;
        currentHealth = maxHealth;
    }
}
