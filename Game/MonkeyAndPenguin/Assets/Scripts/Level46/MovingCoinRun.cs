using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCoinRun : MonoBehaviour
{
    public Transform pointA,pointB,pointC,pointD,pointE;
    protected Player player;

    // Start is called before the first frame update
    void Start()
    {
        player=GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {

        float distance=Vector3.Distance(transform.localPosition,player.transform.localPosition);
        Vector3 direction=player.transform.localPosition - transform.localPosition;

        if(direction.x<0&&direction.y<0)
      {
        if(distance<1.5f)
        {
            transform.position=pointB.position;
        }
      }
      else if(direction.x<0&&direction.y>0)
      {
        if(distance<1.5f)
        {
            transform.position=pointE.position;
        }
      }
      else if(direction.x>0&&direction.y<0)
      {
        if(distance<1.5f)
        {
            transform.position=pointC.position;
        }
      }
      else if(direction.x>0&&direction.y>0)
      {
        if(distance<1.5f)
        {
            transform.position=pointD.position;
        }
      }  
      else
      {
          if(distance<1.5f)
        {
            transform.position=pointA.position;
        }
      }
    }    

}
