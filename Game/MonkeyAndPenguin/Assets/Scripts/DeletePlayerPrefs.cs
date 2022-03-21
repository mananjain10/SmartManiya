using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlayerPrefs : MonoBehaviour
{
    // Update is called once per frame
    public void Deleteprefs()
    {
        
            PlayerPrefs.DeleteAll();
        
    }
}
