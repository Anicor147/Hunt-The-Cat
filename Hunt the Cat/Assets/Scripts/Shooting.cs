using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shooting : MonoBehaviour
{

    
    public Transform FirePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;
    public float firespeed = 0.5f;

    public float ShakeIntensity = 0f;
    public float ShakeTime = 0f;

    // Update is called once per frame
    void Update()
    {

        
        if(Input.GetButtonDown("Fire1") )
        {
            Shoot();
              Shake.Instance.ShakeCamera(ShakeIntensity,ShakeTime);
        }    

    }


void Shoot()
{
 GameObject bullet = Instantiate(bulletPrefab , FirePoint.position , FirePoint.rotation);

    Rigidbody2D body = bullet.GetComponent<Rigidbody2D>();

    body.AddForce(FirePoint.up * bulletForce , ForceMode2D.Impulse);

    

}


}
