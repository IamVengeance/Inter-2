using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitpoints = 8;
    public BossHealthBar Healthbar;
    

    
    void Start()
    {
        Healthbar.SetHealth(Hitpoints, MaxHitpoints);
    }

    
    public void TakeHit(float damage)
    {
        
        Hitpoints -= damage;
        Healthbar.SetHealth(Hitpoints, MaxHitpoints);
        
        if (Hitpoints <= 0){
            Destroy(gameObject);
        }
        
    }
}
