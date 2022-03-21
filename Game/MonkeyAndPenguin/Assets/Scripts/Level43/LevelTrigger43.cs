using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTrigger43 : MonoBehaviour
{
    private LevelAnimation43 levelAnim;
    public GameObject killwall;
    public Transform currentTarget;
    public float speed;
    bool isTouch=false;

    // Start is called before the first frame update
    void Start()
    {
        levelAnim=GetComponent<LevelAnimation43>();     
    }

    void Update()
    {
        if(isTouch==true)
        {
            if(killwall!=null)
                killwall.transform.position=Vector3.MoveTowards(killwall.transform.position, currentTarget.position, speed*Time.deltaTime);
        }
        
    }

    private void OnTriggerStay2D(Collider2D other) 
    {
        if(other.tag=="Player")
        {
            Player player=other.GetComponent<Player>();

            if(player!=null)
            {
                levelAnim.Touch();
                levelAnim.Touchagain();
                isTouch=true;
                StartCoroutine(Stopkillwall());
            }
        } 
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.tag=="Player")
        {
            Player player=other.GetComponent<Player>();
            Debug.Log("out");
            StopAllCoroutines();
        }                
    }

    IEnumerator Stopkillwall()
    {
        yield return new WaitForSeconds(10.1f);
        isTouch=false;
        Destroy(killwall,2f);
    }
}
