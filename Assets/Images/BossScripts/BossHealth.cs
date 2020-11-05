using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public int MaxHealth;
    public int CurrentHealth;
    public Slider HealthBar;

    void Start()
    {   
        CurrentHealth = MaxHealth;
        HealthBar.maxValue = MaxHealth;

        
    }

    
    void Update()
    {   
        if (CurrentHealth <= 0){

            Destroy (gameObject);
        }

        HealthBar.value = CurrentHealth;
        
    }
    public void HurtBoss(int damageToGive)
    {
        CurrentHealth -= damageToGive;

    }

    public void SetMaxHealth()
    {
        CurrentHealth = MaxHealth;
    }

    void OnCollisionEnter2D(Collision2D other)

    {
        if (other.gameObject.tag == "Bullet")
        {
           HurtBoss(10);
        }
    }
}

