using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl16 : MonoBehaviour
{

    private LevelAnimation levelAnim;
    public GameObject wait16;

    private CircleCollider2D www;
    // Start is called before the first frame update
    void Start()
    {
        levelAnim=GetComponent<LevelAnimation>();     
        www=GetComponentInChildren<CircleCollider2D>();
        StartCoroutine(Waitlevel());
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        StartCoroutine(Waitlevel());
        
         if(other.tag=="Player")
         {
             Player player=other.GetComponent<Player>();

             if(player!=null)
             {
                levelAnim.Touchagain();
             }
         } 

    }

    IEnumerator Waitlevel()
    {
        yield return new WaitForSeconds(15f);
        www.enabled=false;
    }
}
