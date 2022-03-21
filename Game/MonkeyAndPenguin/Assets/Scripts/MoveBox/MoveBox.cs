using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour
{
    private Rigidbody2D rb2D;
    PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        player=GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        Wanttomove();
    }

    void Wanttomove()
    {
        float distance=Vector3.Distance(transform.localPosition,player.transform.localPosition);
        //Debug.Log(""+transform.position);
        //Debug.Log(""+distance);
        var hhh=GameObject.FindGameObjectWithTag("Box");

        if(distance<1.2f)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                RaycastHit2D hitUp = Physics2D.Raycast (transform.position + new Vector3(0.0f, 0.7f, 0.0f), Vector2.up);
                RaycastHit2D hitDown = Physics2D.Raycast (transform.position + new Vector3(0.0f, -0.7f, 0.0f), -Vector2.up);
                RaycastHit2D hitRight = Physics2D.Raycast (transform.position + new Vector3(0.7f, 0.0f, 0.0f), Vector2.right);
                RaycastHit2D hitLeft = Physics2D.Raycast (transform.position + new Vector3(-0.7f, 0.0f, 0.0f), -Vector2.right);
                if (hitUp.collider.tag == "Player")
                {
                    //Debug.Log("Up");
                    if(hitDown.collider.tag!="Box")
                    {
                       Debug.Log("work");
                       transform.position=new Vector3(transform.position.x,transform.position.y-1,transform.position.z);
                    }
                    else if(hitDown.collider.tag=="Box")
                    {
                        if(Mathf.Abs((hhh.transform.position - transform.position).y) > 1)
                        {
                             Debug.Log("work   "+Mathf.Abs((transform.localPosition - hhh.transform.localPosition).y));
                             transform.position=new Vector3(transform.position.x,transform.position.y-1,transform.position.z);
                        }
                    }
                }
                else if (hitDown.collider.tag == "Player")
                {
                    if(hitUp.collider.tag!="Box")
                    {
                       Debug.Log("work2");
                       transform.position=new Vector3(transform.position.x,transform.position.y+1,transform.position.z);
                    }
                    else if(hitUp.collider.tag=="Box")
                    {
                        if(Mathf.Abs((transform.position - hhh.transform.position).y) > 1)
                        {
                             Debug.Log("work210   "+Mathf.Abs((transform.localPosition - hhh.transform.localPosition).y));
                             transform.position=new Vector3(transform.position.x,transform.position.y+1,transform.position.z);
                        }
                    }
                }
                else if (hitLeft.collider.tag == "Player")
                {
                    if(hitRight.collider.tag!="Box")
                    {
                       Debug.Log("work3");
                       transform.position=new Vector3(transform.position.x+1,transform.position.y,transform.position.z);
                    }
                    else if(hitRight.collider.tag=="Box")
                    {
                        if(Mathf.Abs((transform.position - hhh.transform.position).x) > 1)
                        {
                             Debug.Log("work310   "+Mathf.Abs((transform.localPosition - hhh.transform.localPosition).y));
                             transform.position=new Vector3(transform.position.x+1,transform.position.y,transform.position.z);
                        }
                    }
                }
                else if (hitRight.collider.tag == "Player")
                {
                    if(hitLeft.collider.tag!="Box")
                    {
                       Debug.Log("work4");
                       transform.position=new Vector3(transform.position.x-1,transform.position.y,transform.position.z);
                    }   
                    else if(hitLeft.collider.tag=="Box")
                    {
                        if(Mathf.Abs((transform.position - hhh.transform.position).y) > 1)
                        {
                             Debug.Log("work410   "+Mathf.Abs((transform.localPosition - hhh.transform.localPosition).y));
                             transform.position=new Vector3(transform.position.x-1,transform.position.y,transform.position.z);
                        }
                    }
                }
                
            }
        }
    }
}
