using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downcollider : MonoBehaviour
{
    public LayerMask whatStopsMovement;    
    public GameObject upobject;
    

    
    private void OnTriggerEnter2D(Collider2D other) 
    {        
        if(other.tag=="Player")
        {
            PlayerController player=other.GetComponent<PlayerController>();

            if(player!=null)
            {
                if(!Physics2D.OverlapCircle(upobject.transform.position,.05f,whatStopsMovement))
                {
                    Debug.Log("down working");
                    transform.parent.position=new Vector3(transform.parent.position.x,transform.parent.position.y+1,transform.parent.position.z);
                }
            }
        } 
    }    
    
}
