using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl19trigger : MonoBehaviour
{
    private LevelAnimation levelAnim;
    // variable to hold shaking acceleration value
	Vector3 accelerationDir;
    // Start is called before the first frame update
    void Start()
    {
        levelAnim=GetComponent<LevelAnimation>();     
    }

    // Update is called once per frame
	void Update () {
		
		// Read new acceleration Input from mobile device
		accelerationDir = Input.acceleration;

		// If you shake the mobile device hard enough
		// (accelerations Square Magnitude greater then 5 for example)
		if (accelerationDir.sqrMagnitude >= 5f) 
        {
            levelAnim.Touch();
            levelAnim.Touchagain();			
		}
	}
}
