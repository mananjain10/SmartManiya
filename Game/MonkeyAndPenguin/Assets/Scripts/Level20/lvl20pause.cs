using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl20pause : MonoBehaviour
{
 public static bool GameisPaused = false;
 public GameObject pauseMenuUI;
 public GameObject bbb;

 void Start () 
 {
  pauseMenuUI.SetActive (false);
  bbb.SetActive(true);
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
  bbb.SetActive(true);
  GameisPaused = false;  
 }
 public void Pause ()
 {
  pauseMenuUI.SetActive (true);
  bbb.SetActive(false);
  GameisPaused = true;
 }
}
