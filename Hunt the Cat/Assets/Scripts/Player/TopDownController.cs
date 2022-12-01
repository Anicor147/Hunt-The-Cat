using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{

 

    public Rigidbody2D body;
    public SpriteRenderer spriteRenderer;

    public Camera cam;


    public float walkSpeed;
    public float frameRate;

    Vector2  direction;
    Vector2 mousePos;

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;



    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        
    }

    // Update is called once per frame
    void Update()
    {   
        //get direction of input
        direction = new Vector2( Input.GetAxisRaw("Horizontal") ,Input.GetAxisRaw("Vertical") ).normalized;
        //set walk based on direction
        body.velocity = direction * walkSpeed;

 
    }

   

}
