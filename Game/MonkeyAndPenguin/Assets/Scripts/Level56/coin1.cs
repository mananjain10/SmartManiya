using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin1 : MonoBehaviour
{
    coinanimation coinanim;
    public bool coin1b=false;
    public coin2 coin2s;
    public coin3 coin3s;
    public coin4 coin4s;
    // Start is called before the first frame update
    void Start()
    {
        coinanim=GetComponent<coinanimation>();   
        coin2s=GetComponent<coin2>();
        coin3s=GetComponent<coin3>();
        coin4s=GetComponent<coin4>();
    }
    void Update()
    {
        if(coin1b)
        {
            coinanim.Coin(true);
        }
        else if(coin1b==false)
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
                coin1b=true;
                coin2s.coin2b=false;
                coin3s.coin3b=false;
                coin4s.coin4b=false;
             }
         }

    }
}
