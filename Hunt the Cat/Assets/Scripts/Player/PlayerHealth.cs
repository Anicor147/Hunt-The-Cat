using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
     public int maxHealth = 200;
     public int currentHealth;
     public int DamageTaken =10;
    public HealthBar healthBar;
  void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);


        if(currentHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    



    public void OnTriggerEnter2D(Collider2D col)
    {
    Debug.Log("DamageTaken");
    TakeDamage(DamageTaken);
    }

    

}
