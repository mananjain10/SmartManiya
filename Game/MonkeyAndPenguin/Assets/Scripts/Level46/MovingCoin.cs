using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCoin : MonoBehaviour
{
    public Transform pointA,pointB,pointC,pointD,pointE,pointF,pointG,pointH,pointI;
    Vector3 currentTarget;
    public float speed;
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
        if(transform.position==pointA.position)
        {
            currentTarget=pointB.position;  
        }

        else if(transform.position==pointB.position)
        {
            currentTarget=pointC.position;
        }

        else if(transform.position==pointC.position)
        {
            currentTarget=pointD.position;
        }

        else if(transform.position==pointD.position)
        {
            currentTarget=pointE.position;
        }

        else if(transform.position==pointE.position)
        {
            currentTarget=pointF.position;
        }

        else if(transform.position==pointF.position)
        {
            currentTarget=pointA.position;
        }

        else if(transform.position==pointG.position)
        {
            currentTarget=pointA.position;
        }   

        else if(transform.position==pointH.position)
        {
            currentTarget=pointA.position;
        }      

        transform.position=Vector3.MoveTowards(transform.position,currentTarget,speed*Time.deltaTime);

        float distance=Vector3.Distance(transform.localPosition,player.transform.localPosition);
        Vector3 direction=player.transform.localPosition - transform.localPosition;
        //Debug.Log(""+distance);
        //Debug.Log(""+direction);
        if(direction.x<0)
      {
        if(distance<2.0f)
        {
            currentTarget=pointG.position;
            transform.position=Vector3.MoveTowards(transform.position,currentTarget,10*Time.deltaTime);
        }
      }
      else if(direction.x>0)
      {
        if(distance<2.0f)
        {
            currentTarget=pointH.position;
            transform.position=Vector3.MoveTowards(transform.position,currentTarget,10*Time.deltaTime);
        }
      }
        

    }
}
