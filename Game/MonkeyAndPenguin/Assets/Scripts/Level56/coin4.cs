using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin4 : MonoBehaviour
{
    coinanimation coinanim;
    public bool coin4b=false;
    // Start is called before the first frame update
    void Start()
    {
        coinanim=GetComponent<coinanimation>();   
    }
    void Update()
    {
        if(coin4b)
        {
            coinanim.Coin(true);
        }
        else if(coin4b==false)
        {
            coinanim.Coin(false);
        }
    }

    private void OnTriggerStay2D(Collider2D other) 
    {
         if(other.tag=="Player")
         {
             Player player=other.GetComponent<Player>();

             if(player!=null)
             {
                coin4b=true;
             }
         }

    }
}
