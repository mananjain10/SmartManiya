using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLostCave : MonoBehaviour
{
    //public string sceneToLoad;
    //public Vector2 playerPosition;
    //public VectorValue playerStorage;
    public Camera cam;
    public Vector3 campos;
    public GameObject player;
    public Vector3 playerPos;
    public Image fade;
    public GameObject canfade;

    void Start()
    {
        canfade.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag=="Player" && !other.isTrigger)
         {
             canfade.SetActive(true);
             fade.canvasRenderer.SetAlpha(1.0f);
             cam.transform.position=campos;
             player.transform.position=playerPos;
             fade.CrossFadeAlpha(0,1,false);
             StartCoroutine(Fadestop());
             //playerStorage.initialValue=playerPosition;
             //SceneManager.LoadScene(sceneToLoad);
         }        
    }

    IEnumerator Fadestop()
    {
        yield return new WaitForSeconds(1f);
        canfade.SetActive(false);
        
    }
}
