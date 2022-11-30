using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
public PlayerHealth ph;
public int DamageReceveid;



public void OnParticleCollisionEnter2D(Collision2D coll)
{
   
    ph.TakeDamage(DamageReceveid);
}


}
