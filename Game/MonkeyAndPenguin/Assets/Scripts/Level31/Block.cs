using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Block : MonoBehaviour
{
    public float health=3f;
    public GameObject deathEffect;
    
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
        Destroy(gameObject);
        //this.enabled=false;
    }

    
}