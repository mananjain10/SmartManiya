using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerneardoor : MonoBehaviour
{
    [SerializeField]
	GameObject codePanel, closedSafe, openedSafe;
    public static bool isSafeOpened = false;


    // Start is called before the first frame update
    void Start()
    {
        codePanel.SetActive (false);
		closedSafe.SetActive (true);
		openedSafe.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isSafeOpened) {
			codePanel.SetActive (false);
			closedSafe.SetActive (false);
			openedSafe.SetActive (true);
		}
    }

    /*void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name.Equals ("Safe") && !isSafeOpened) {
			codePanel.SetActive (true);
		}
	}
    
	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.name.Equals ("Safe")) {
			codePanel.SetActive (false);
		}
	}
    */
    private void OnTriggerEnter2D(Collider2D other) 
    {
         if(other.tag=="Player" && !isSafeOpened)
         {
             Player player=other.GetComponent<Player>();

             if(player!=null)
             {
                codePanel.SetActive (true);
             }
         } 
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
         if(other.tag=="Player")
         {
             Player player=other.GetComponent<Player>();

             if(player!=null)
             {
                codePanel.SetActive (false);
             }
         } 

    }
}
