using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TeleportSystem : MonoBehaviour
{
    //public string sceneToLoad;
    //public Vector2 playerPosition;
    //public VectorValue playerStorage;
    
    
    public GameObject player;
    public Vector3 playerPos;
    
    

    

    public void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag=="Player" && !other.isTrigger)
         {
            
             player.transform.position=playerPos;
             
             //playerStorage.initialValue=playerPosition;
             //SceneManager.LoadScene(sceneToLoad);
         }        
    }

    
}
