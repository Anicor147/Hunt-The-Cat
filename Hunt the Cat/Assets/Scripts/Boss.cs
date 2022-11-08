using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Boss : MonoBehaviour
{
 
   
     public int maxbHealth = 200;
     public int currentbHealth;
    public BossHealthBar BosshealthBar;


     void Start()
    {
        currentbHealth = maxbHealth;
        BosshealthBar.SetBossMaxHealth(maxbHealth);
        
    }



    void OnCollisionEnter2D(Collision2D col )
    {
        
        TakeDamage(25);
        Debug.Log("25 Damage");
    }
    
    


    public void TakeDamage(int damage)
    {
        currentbHealth -= damage;
        BosshealthBar.SetBossHealth(currentbHealth);


        if(currentbHealth == 0)
        {
            Destroy(gameObject);
            BosshealthBar.DeadBoss();

        }
    }


}
