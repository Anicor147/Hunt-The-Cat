using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuletPatern3 : MonoBehaviour
{
       

   

    [SerializeField]
    private float Firerate = 2f;
    private float angle = 0f;

    private Vector2 bulletMoveDirection;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire",0f ,Firerate);    
    }

    private void Fire()
    {
   
            for(int i = 0 ; i<=1 ; i++)
        {
        
            float bulDirX = transform.position.x + Mathf.Sin(((angle +180 *i) * Mathf.PI)/ 180f);
            float bulDirY = transform.position.y + Mathf.Cos(((angle +180 *i)* Mathf.PI)/ 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX , bulDirY ,0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BossBulletPool.bulletPoolInstance.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<BossBullet>().SetMoveDirection(bulDir);

            
        }
            angle += 10f; 

        if (angle >=360f)
        {
            angle = 0f;
        }
        
     
    }
  
}
