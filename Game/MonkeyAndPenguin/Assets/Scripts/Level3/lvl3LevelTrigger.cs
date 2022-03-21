using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl3LevelTrigger : MonoBehaviour
{
    public GameObject coin=null;
    private LevelAnimation levelAnim;
    // Start is called before the first frame update
    void Start()
    {
        levelAnim=GetComponent<LevelAnimation>();     
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D coll= coin.GetComponent<Collider2D>();

            if(coll.OverlapPoint(wp))
            {
                levelAnim.Touch();
                levelAnim.Touchagain();
            }
        }
    }
}
