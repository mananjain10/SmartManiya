using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin2 : MonoBehaviour
{
    coinanimation coinanim;
    public bool coin2b=false;
    public coin3 coin3s;
    public coin4 coin4s;
    // Start is called before the first frame update
    void Start()
    {
        coinanim=GetComponent<coinanimation>();   
        coin3s=GetComponent<coin3>();
        coin4s=GetComponent<coin4>();
    }
    void Update()
    {
        if(coin2b)
        {
            coinanim.Coin(true);
        }
        else if(coin2b==false)
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
                coin2b=true;
                coin3s.coin3b=false;
                coin4s.coin4b=false;
             }
         }

    }
}
