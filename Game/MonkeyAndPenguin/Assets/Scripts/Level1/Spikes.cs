using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    [SerializeField]
    Transform spawnpoint;
    GameObject newdeadbodyprefab;

    public GameObject deadbodyprefab;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        
         if(other.tag=="Player")
        {
            Player player=other.GetComponent<Player>();
            Debug.Log("aaaa");

            if(player!=null)
            {
                StartCoroutine(Dead());
                Vector2 spawnPos=GameObject.Find("Player").transform.position;
                newdeadbodyprefab= Instantiate(deadbodyprefab,spawnPos,Quaternion.identity);
                other.transform.position=spawnpoint.position;
                
            }
        }

    }

    IEnumerator Dead()
    {
        
        Destroy(newdeadbodyprefab);
        yield return new WaitForSeconds(0.2f);
    }
}
