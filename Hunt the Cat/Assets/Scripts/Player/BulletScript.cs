using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject hitEffect;
    public Boss Boss;
    public int Damage;
    


        
  
    
    public void OnCollisionEnter2D(Collision2D collision)
    { 
       
       GameObject effect = Instantiate(hitEffect, transform.position , Quaternion.identity );
        Destroy(effect, 0.5f);
        Destroy(gameObject);
        
          Debug.Log(Boss);
       Boss.TakeDamage(Damage);
       
        
  
    }
    

    

}
