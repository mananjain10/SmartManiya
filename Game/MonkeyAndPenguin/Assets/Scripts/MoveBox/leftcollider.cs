using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftcollider : MonoBehaviour
{
    public GameObject rightobject;
    public LayerMask whatStopsMovement;
    

    
    private void OnTriggerEnter2D(Collider2D other) 
    {        
        if(other.tag=="Player")
        {
            PlayerController player=other.GetComponent<PlayerController>();

            if(player!=null)
            {
                if(!Physics2D.OverlapCircle(rightobject.transform.position,.05f,whatStopsMovement))
                {                   
                    Debug.Log("left working");
                    transform.parent.position=new Vector3(transform.parent.position.x+1,transform.parent.position.y,transform.parent.position.z);                    
                } 
            }
        } 
    }
    
}
