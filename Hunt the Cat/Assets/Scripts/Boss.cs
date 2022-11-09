using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Boss : MonoBehaviour
{
 
   
     public int maxbHealth = 200;
     public int currentbHealth;
     public int DamageTaken =10;
    public BossHealthBar BosshealthBar;


     void Start()
    {
        currentbHealth = maxbHealth;
        BosshealthBar.SetBossMaxHealth(maxbHealth);
        
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
