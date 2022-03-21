using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTrigger : MonoBehaviour
{

    private LevelAnimation levelAnim;
    // Start is called before the first frame update
    void Start()
    {
        levelAnim=GetComponent<LevelAnimation>();     
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
         if(other.tag=="Player")
         {
             Player player=other.GetComponent<Player>();

             if(player!=null)
             {
                levelAnim.Touch();
                levelAnim.Touchagain();
             }
         } 

    }
}
