using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightcollider : MonoBehaviour
{
    public GameObject leftobject;
    public LayerMask whatStopsMovement;
    

    
    private void OnTriggerEnter2D(Collider2D other) 
    {        
        if(other.tag=="Player")
        {
            PlayerController player=other.GetComponent<PlayerController>();

            if(player!=null)
            {
                if(!Physics2D.OverlapCircle(leftobject.transform.position,.05f,whatStopsMovement))
                {                   
                    Debug.Log("right working");
                    transform.parent.position=new Vector3(transform.parent.position.x-1,transform.parent.position.y,transform.parent.position.z);                    
                }
            }
        } 
    }
    
}
