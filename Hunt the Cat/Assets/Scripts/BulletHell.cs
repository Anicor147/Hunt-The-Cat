using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHell : MonoBehaviour
{
    public int number_of_columns;
    public float speed;
    public Sprite texture;
    public Color color;
    public float lifetime;
    public float firerate;
    public float size;
    private float angle;
    public Material material;
    public float spin_speed;
    private float time;

 

    private void Awake()
    {
        Summon();
    }

    private void FixedUpdate()
    {   
    time += Time.fixedDeltaTime;
    transform.rotation = Quaternion.Euler(0,0, time * spin_speed);
    }


    public ParticleSystem system;

      void Summon()
    {

        angle = 360f / number_of_columns;

        for(int i=0 ; i<number_of_columns ; i++)
        {
        // A simple particle material with no texture.
        Material particleMaterial = material;

        // Create a green Particle System.
        var go = new GameObject("Particle System");
        go.transform.Rotate(angle * i, 90, 0); // Rotate so the system emits upwards.
        go.transform.parent = this.transform;
        go.transform.position = this.transform.position;

        system = go.AddComponent<ParticleSystem>();
        go.GetComponent<ParticleSystemRenderer>().material = particleMaterial;
        var mainModule = system.main;
        mainModule.startColor = Color.green;
        mainModule.startSize = 0.1f;
        mainModule.startSpeed = speed;
        mainModule.maxParticles = 100000;
       
        mainModule.simulationSpace = ParticleSystemSimulationSpace.World;


        var emissions= system.emission;
        emissions.enabled = false;

        var forma = system.shape;
        forma.enabled = true;
        forma.shapeType = ParticleSystemShapeType.Sprite;
        forma.sprite = null;

        var text = system.textureSheetAnimation;
        text.mode = ParticleSystemAnimationMode.Sprites;
        text.AddSprite(texture);

        var col = system.collision;
        col.enabled = true;
        col.type = ParticleSystemCollisionType.World;
        col.mode = ParticleSystemCollisionMode.Collision2D;
       // col.lifetimeLoss = 1;
        

        }
        // Every 2 secs we will emit.
        InvokeRepeating("DoEmit", 0f, firerate);
    }

    void DoEmit()
    {
        foreach(Transform child in transform)
        {
            system = child.GetComponent<ParticleSystem>();
        // Any parameters we assign in emitParams will override the current system's when we call Emit.
        // Here we will override the start color and size.
        var emitParams = new ParticleSystem.EmitParams();
        emitParams.startColor = color;
        emitParams.startSize = size;
        emitParams.startLifetime = lifetime;
        system.Emit(emitParams, 10);
        
        }
    }
    
}
