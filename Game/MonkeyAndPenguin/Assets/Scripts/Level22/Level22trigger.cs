using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level22trigger : MonoBehaviour
{

    private Level22Animation levelAnim;
    [SerializeField] GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        levelAnim=GetComponent<Level22Animation>();    
        door.SetActive(false); 
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
         if(other.tag=="Player")
         {
             Player player=other.GetComponent<Player>();

             if(player!=null)
             {
                levelAnim.TouchCutCoin();
                door.SetActive(true);
                levelAnim.DoorVisible();
             }
         } 

    }
}
