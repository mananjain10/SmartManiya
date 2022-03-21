using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leveltrigger14 : MonoBehaviour
{

    private levelanimation14 levelAnim;
    [SerializeField]
    private string newlevel;
    // Start is called before the first frame update
    void Start()
    {
        levelAnim=GetComponent<levelanimation14>();     
    }

    private void OnTriggerStay2D(Collider2D other) 
    {
         if(other.tag=="Player")
         {
             Player player=other.GetComponent<Player>();

             if(player!=null)
             {
                levelAnim.Touch();
                levelAnim.OpenG(true);
                levelAnim.CloseG(false);
                StartCoroutine(Passlevel());
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
            levelAnim.CloseG(true);
            levelAnim.OpenG(false);
        }                
    }

    IEnumerator Passlevel()
    {
        yield return new WaitForSeconds(7f);
        SceneManager.LoadScene(newlevel);
    }
}

