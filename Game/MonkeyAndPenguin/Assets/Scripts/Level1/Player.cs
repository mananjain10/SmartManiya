using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class Player : MonoBehaviour
{
    
    [SerializeField]
    private LayerMask groundlayer;
    private Rigidbody2D _rigid;
    [SerializeField]
    private float _jumpforce = 11.5f;
    [SerializeField]
    private float _speed = 5.0f;
    private bool _grounded=false;
    private bool _resetJump = false;
    private PlayerAnimation _playerAnim;
    private SpriteRenderer _playerSprite;
    private BoxCollider2D boxCollider2d;

    // Start is called before the first frame update
    void Start()
    {
        _rigid=GetComponent<Rigidbody2D>();    
        _playerAnim = GetComponent<PlayerAnimation> ();
        _playerSprite=GetComponentInChildren<SpriteRenderer>();    
        boxCollider2d=transform.GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float move=CrossPlatformInputManager.GetAxis("Horizontal"); //Input.GetAxisRaw ("Horizontal");

        _grounded=IsGrounded();
        if (move > 0) 
        {
            Flip(true);
        } else if (move < 0) 
        {
           Flip(false);

        }

        if ((Input.GetKeyDown (KeyCode.Space) || CrossPlatformInputManager.GetButtonDown("Jump")) && IsGrounded ()==true) 
        {
            Debug.Log ("Jump");
            _rigid.velocity = new Vector2 (_rigid.velocity.x, _jumpforce);
            StartCoroutine (ResetJumpRoutine ());
            _playerAnim.Jump(true);
        }

        _rigid.velocity=new Vector2(move*_speed,_rigid.velocity.y);
        _playerAnim.Move(move);
        
    }

    bool IsGrounded () 
    {
        RaycastHit2D hitInfo = Physics2D.BoxCast(boxCollider2d.bounds.center,boxCollider2d.bounds.size,0f,Vector2.down,0.1f,groundlayer);
        Debug.Log(hitInfo.collider);

        if (hitInfo.collider != null) {
            if (_resetJump == false)
                {
                    Debug.Log("Grounded");
                    _playerAnim.Jump(false); 
                    return true;
                }    
        }

        return false;
    }

    IEnumerator ResetJumpRoutine () {
        _resetJump = true;
        yield return new WaitForSeconds (0.1f);
        _resetJump = false;
    }

    void Flip(bool faceRight)
    {
        if(faceRight==true)
        {
            _playerSprite.flipX=false;   
        }
        else if(faceRight==false)
        {
            _playerSprite.flipX=true;
        }
    }

    
}
