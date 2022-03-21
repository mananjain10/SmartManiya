using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes13 : MonoBehaviour
{
    [SerializeField]
    Transform spawnpoint;
   private void OnTriggerEnter2D(Collider2D other) 
    {
        
         if(other.tag=="Player")
        {
            Player player=other.GetComponent<Player>();
            Debug.Log("aaaa");

            if(player!=null)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

    }
}
