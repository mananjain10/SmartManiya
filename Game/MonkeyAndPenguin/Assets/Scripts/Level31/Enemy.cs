using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public float health=4f;
    public GameObject deathEffect;
    public static int EnemiesAlive=0;   
    
    void Start()
    {
        EnemiesAlive++;       
        
    }
    
    void OnCollisionEnter2D(Collision2D colInfo)
    {
        if(colInfo.relativeVelocity.magnitude>health)
        {
            Die();
        }
    }
    void Die()
    {
        Instantiate(deathEffect,transform.position,Quaternion.identity);
        EnemiesAlive--;
        Destroy(gameObject);
        //this.enabled=false;
    }

    
}