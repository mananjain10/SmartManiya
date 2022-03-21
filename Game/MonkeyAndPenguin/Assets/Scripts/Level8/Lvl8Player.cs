using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Lvl8Player : MonoBehaviour
{

    private Rigidbody2D rb;
    private Player player;
    private SpriteRenderer _playerSprite;
    private bool top;

    // Start is called before the first frame update
    void Start()
    {
        player=GetComponent<Player>();
        rb=GetComponent<Rigidbody2D>();
        _playerSprite=GetComponentInChildren<SpriteRenderer>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space) || CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            rb.gravityScale*=-1;
            Rotation();
        }

    }

    void Rotation()
    {
        if(top==false)
        {
            _playerSprite.flipY=true;
        }
        else
        {
            _playerSprite.flipY=false;
        }
        
        top=!top;
        
    }
    
    
}
