using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtBoss : MonoBehaviour
{
    public int damageToGive;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Boss")
        {
            //Destroy (other.gameObject);
            other.gameObject.GetComponent<BossHealth>().HurtBoss(damageToGive);
        }
    }
}
