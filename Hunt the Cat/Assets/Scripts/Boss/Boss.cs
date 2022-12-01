using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Boss : MonoBehaviour
{
 
   
     public int maxbHealth = 200;
     public int currentbHealth;
     public int DamageTaken =10;
     private int pourcentage;
    public BossHealthBar BosshealthBar;
      public Sprite BossAttackMode;
      
   
     void Start()
    {
        currentbHealth = maxbHealth;
        BosshealthBar.SetBossMaxHealth(maxbHealth);
        
    
        
    }
    void Update()
    {
         BossPourcentage(pourcentage);
      
    } 

    public int BossPourcentage( int pourcentage)
    {
    
       pourcentage = (( currentbHealth / maxbHealth) * 100);

       
       return pourcentage;
    }


    public void TakeDamage(int damage)
    {
        currentbHealth -= damage;
        BosshealthBar.SetBossHealth(currentbHealth);

       

    

       if(currentbHealth <= 490)
        {
           
           this.gameObject.GetComponent<SpriteRenderer>().sprite = BossAttackMode; 

           gameObject.GetComponent<BossMovement>().enabled = true;
           
           gameObject.GetComponent<BulelPattern2>().enabled = true;                             
        }
        if(currentbHealth <=470 )
        {          
           gameObject.GetComponent<BuletPatern3>().enabled = true;       
           gameObject.GetComponent<FireBossBullet>().enabled = true;
        }
         if(currentbHealth <=400 )
        {                   
           gameObject.GetComponent<FireBossBullet>().enabled = true;
        }

        if(currentbHealth == 0)
        {
         SceneManager.LoadScene("End");

        }
    }


   





}
