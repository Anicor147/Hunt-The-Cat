using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthBar : MonoBehaviour
{
    
    
    public Slider bslider;
    public void SetBossMaxHealth(int bhealth)
    {
        bslider.maxValue = bhealth;
        bslider.value = bhealth;
    }

    public void SetBossHealth(int bhealth)
    {
        bslider.value = bhealth;
    }
    


    public void DeadBoss()
    {
        Destroy(gameObject);
    }
}
