using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shooting : MonoBehaviour
{

    
    public Transform FirePoint;
    public GameObject bulletPrefab;
    AudioSource Audio;
   
    

    public float bulletForce = 20f;
    public float firespeed = 10;

    public float ShakeIntensity = 0f;
    public float ShakeTime = 0f;
    
   
    float ReadyForNextShot;
    
    

    // Update is called once per frame
    void Update()
    {
       
        
      
            if(Input.GetMouseButton(0) )
            {
               
                
              if(Time.time > ReadyForNextShot)
                {
                    ReadyForNextShot = Time.time +1/firespeed;
                    Shoot();
                }
            
              Shake.Instance.ShakeCamera(ShakeIntensity,ShakeTime);
            }
        
        
    }



void Shoot()
{
   if(Time.time > -1f)
    {

        
      
    GameObject bullet = Instantiate(bulletPrefab , FirePoint.position , FirePoint.rotation);

    Rigidbody2D body = bullet.GetComponent<Rigidbody2D>();

    body.AddForce(FirePoint.up * bulletForce , ForceMode2D.Impulse);

    
    }

}


}


    
