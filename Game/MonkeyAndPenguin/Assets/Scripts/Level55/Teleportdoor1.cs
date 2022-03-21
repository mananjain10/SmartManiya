using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportdoor1 : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool isPressed=false;

    public GameObject player;
    public GameObject door2;


    void Update()
    {
        if(isPressed)
        {
            Vector2 mousePos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
            rb.position=mousePos;
        }
    }
    void OnMouseDown()
    {
        isPressed=true;
           
    }
    void OnMouseUp()
    {
        isPressed=false;
              
    }

    public void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag=="Player" && !other.isTrigger)
         {
            
             player.transform.position=door2.transform.position+new Vector3(1f,0f,0f);
             
             //playerStorage.initialValue=playerPosition;
             //SceneManager.LoadScene(sceneToLoad);
         }        
    }
}
