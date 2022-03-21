    using UnityEngine;
    using System.Collections;
    using UnityStandardAssets.CrossPlatformInput;
    public class PlayerController : MonoBehaviour
    {
        public float speed;
        private Animator animator;

        private SpriteRenderer _playerSprite;
     
        // Use this for initialization
        void Start()
        {
            _playerSprite=GetComponentInChildren<SpriteRenderer>();
            animator = GetComponentInChildren<Animator>();
        }
     
        // Update is called once per frame
        void Update()
        {
            Vector2 moveDirection = Vector2.zero;
            var vertical = CrossPlatformInputManager.GetAxis("Vertical"); //Input.GetAxis("Vertical");
            var horizontal = CrossPlatformInputManager.GetAxis("Horizontal"); //Input.GetAxis("Horizontal");
       
            if (horizontal > 0)
            {
                moveDirection.x = 1;
                Flip(true);
                animator.SetInteger("Direction", 2);
            }
            else if (horizontal < 0)
            {
                moveDirection.x = -1;
                Flip(false);
                animator.SetInteger("Direction", 3);
            }
            else if (vertical > 0)
            {
                moveDirection.y = 1;
                animator.SetInteger("Direction", 1);
            }
            else if (vertical < 0)
            {
                moveDirection.y = -1;
                animator.SetInteger("Direction", 1);
            }
            else
            {
                animator.SetInteger("Direction", 0);
            }
            transform.Translate(moveDirection * speed* Time.deltaTime, Space.World);
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
