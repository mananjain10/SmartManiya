using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseM : MonoBehaviour {

 public static bool GameisPaused = false;
 public GameObject pauseMenuUI;

 void Start () 
 {
  pauseMenuUI.SetActive (false);
 }

 // Update is called once per frame
 void Update () {
  
   if (GameisPaused) 
   {
    Resume ();
   } else 
   {
    Pause ();
   }

}

public void PauseButton()
{
    if (GameisPaused) 
   {
    Resume ();
   } else 
   {
    Pause ();
   }
}
 public void Resume ()
 {
  pauseMenuUI.SetActive (false);
  Time.timeScale = 1f;
  GameisPaused = false;
 }
 public void Pause ()
 {
  pauseMenuUI.SetActive (true);
  Time.timeScale = 0f;
  GameisPaused = true;
 }
 public void Restart()
 {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
 }
}