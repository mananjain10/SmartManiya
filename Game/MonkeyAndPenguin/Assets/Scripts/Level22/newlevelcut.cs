using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newlevelcut : MonoBehaviour
{
   public int nextSceneLoad;
   public GameObject happy;
   Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
        anim=happy.GetComponentInChildren<Animator>();
    }

    public void Happy()
    {
        anim.SetTrigger("Happy");
    }

    IEnumerator FinishAnim()
    {
        Happy();
        yield return new WaitForSeconds(2f);  
        //Move to next level
        SceneManager.LoadScene(nextSceneLoad);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(SceneManager.GetActiveScene().buildIndex == 43) /* < Change this int value to whatever your
                                                                   last level build index is on your
                                                                   build settings */
            {
                Debug.Log("You Completed ALL Levels");
                
                //Show Win Screen or Somethin.
            }
            else
            {
                StartCoroutine(FinishAnim());
                

                //Setting Int for Index
                if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
                {
                    PlayerPrefs.SetInt("levelAt", nextSceneLoad);
                }
            }
        }
    }
}
