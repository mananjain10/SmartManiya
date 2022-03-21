using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level31Trigger : MonoBehaviour
{
    private EnemyAnimation levelAnim;
    [SerializeField] GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        levelAnim=GetComponent<EnemyAnimation>();    
        door.SetActive(false);  
    }

    // Update is called once per frame
    void Update()
    {
        if(Enemy.EnemiesAlive<=0)
        {
            //Debug.Log("level jeet gaya");
            door.SetActive(true);
            levelAnim.DoorVisible();                                  
        }
    }
}
