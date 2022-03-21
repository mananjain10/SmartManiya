using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragFingerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool isPressed=false;
    void Update()
    {
        if(isPressed)
        {
            Vector2 mousePos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
            rb.position=mousePos;
        }
    }
    void OnMouseDown()
    {
        isPressed=true;
           
    }
    void OnMouseUp()
    {
        isPressed=false;
              
    }
}

