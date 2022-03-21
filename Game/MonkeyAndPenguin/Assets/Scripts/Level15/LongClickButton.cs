using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongClickButton : MonoBehaviour
{
    public GameObject coin=null;
	float holdtime=0f;
    private LevelAnimation levelAnim;
    // Start is called before the first frame update
    void Start()
    {
        levelAnim=GetComponent<LevelAnimation>();     
    }
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
					
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D coll= coin.GetComponent<Collider2D>();
			
              if(coll.OverlapPoint(wp))
              {
				  holdtime += Time.deltaTime;	
			      Debug.Log(" "+holdtime);
				  if(holdtime>4f)
				  {
					  levelAnim.Touch();
                      levelAnim.Touchagain();
				  }
                  
              }
			
        }

		if(Input.GetMouseButtonUp(0))
		{
			holdtime=0f;
		}
    }
}
