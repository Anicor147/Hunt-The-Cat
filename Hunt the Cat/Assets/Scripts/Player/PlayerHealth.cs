using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    
     public int maxHealth = 200;
     public int currentHealth;
     public int DamageTaken;
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
            SceneManager.LoadScene("Dead");
        }
    }

    



    public void OnTriggerEnter2D(Collider2D col)
    {

    TakeDamage(DamageTaken);
    }

    

}
