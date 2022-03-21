using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin3 : MonoBehaviour
{
    coinanimation coinanim;
    public bool coin3b=false;
    public coin4 coin4s;
    // Start is called before the first frame update
    void Start()
    {
        coinanim=GetComponent<coinanimation>();   
         coin4s=GetComponent<coin4>();
    }
    void Update()
    {
        if(coin3b)
        {
            coinanim.Coin(true);
        }
        else if(coin3b==false)
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
                coin3b=true;
                coin4s.coin4b=false;
             }
         }

    }
}
