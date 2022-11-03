using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{

 

    public Rigidbody2D body;
    public SpriteRenderer spriteRenderer;

    //Create Zone to put Sprite
    public List<Sprite> nSprites;
    public List<Sprite> neSprites;
    public List<Sprite> eSprites;
    public List<Sprite> seSprites;
    public List<Sprite> sSprites;

    public Camera cam;


    public float walkSpeed;
    public float frameRate;

    Vector2  direction;
    Vector2 mousePos;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        //get direction of input
        direction = new Vector2( Input.GetAxisRaw("Horizontal") ,Input.GetAxisRaw("Vertical") ).normalized;
        //set walk based on direction
        body.velocity = direction * walkSpeed;

            HandleSpriteFlip();

      List<Sprite> directionSprites = GetSpriteDirection();

    
       if(directionSprites != null)
        {
        //Holding a Direction        
        spriteRenderer.sprite = directionSprites[0];
        } else
        {
        //holding nothing input is neutral      

        }
 
       mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
 
    }

    // check Position and Mouse 
    void FixedUpdate() 
    {
        Vector2 lookdirection = mousePos - body.position;
        float angle = Mathf.Atan2(lookdirection.y , lookdirection.x) * Mathf.Rad2Deg - 90f;
        body.rotation = angle;

    }

    void HandleSpriteFlip()
    {
             //handle direction
              // if we're facing right  and the player holds left , flip
                 // if we're facing left and the player hold right , flip

           if(!spriteRenderer.flipX && direction.x < 0)
        {
            spriteRenderer.flipX = true;
        } else if(spriteRenderer.flipX && direction.x > 0)
        {
            spriteRenderer.flipX = false;
        }
    }


    List<Sprite> GetSpriteDirection()
    {

        List<Sprite> selectedSprites =  nSprites;

        if(direction.y > 0)
        {//north

        if(Mathf.Abs(direction.x)> 0) // east or west
         {
            selectedSprites = neSprites;
         }
            else // neutral x
            {
                selectedSprites = nSprites;
            }
        }
        else if (direction.y < 0)
        {//south
            if(Mathf.Abs(direction.x)> 0) // east or west
         {
            selectedSprites = seSprites;
         }
            else // neutral x
            {
                selectedSprites = sSprites;
            }
         } else
         {//neutral
            if(Mathf.Abs(direction.x)> 0) // east or west
         {
            selectedSprites = eSprites;
         }
         }

        return selectedSprites;

    }
}
