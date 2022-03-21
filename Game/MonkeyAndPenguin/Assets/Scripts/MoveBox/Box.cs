using UnityEngine;
 using System.Collections;
 
 public class Box : MonoBehaviour {
 
     //public float movementSpeed = 1.5f;
     private Rigidbody2D rb2D;
     public GameObject BlockPosBuild;
 
     // Use this for initialization
     void Start () {
         rb2D = GetComponent<Rigidbody2D>();
     }

     
     
     // Update is called once per frame
     void Update () {
         Vector3 a = BlockPosBuild.transform.position;
 
         Vector3 b = new Vector3(Mathf.RoundToInt(a.x), Mathf.RoundToInt(a.y), Mathf.RoundToInt(a.z));
 
         //this is the gameobject
         BlockPosBuild.transform.position = b;
         //CheckForPlayerHit();
     }
 
     //Check if the player is hitting a box, from one of its four sides. Set the box is kinematic to false, if player hits.
     void CheckForPlayerHit() {
         RaycastHit2D hitUp = Physics2D.Raycast (transform.position + new Vector3(0.0f, 0.7f, 0.0f), Vector2.up);
         RaycastHit2D hitDown = Physics2D.Raycast (transform.position + new Vector3(0.0f, -0.7f, 0.0f), -Vector2.up);
         RaycastHit2D hitRight = Physics2D.Raycast (transform.position + new Vector3(0.7f, 0.0f, 0.0f), Vector2.right);
         RaycastHit2D hitLeft = Physics2D.Raycast (transform.position + new Vector3(-0.7f, 0.0f, 0.0f), -Vector2.right);
         
         if (hitUp.collider.tag == "Player" || hitDown.collider.tag == "Player" || 
             hitRight.collider.tag == "Player" || hitLeft.collider.tag == "Player")
         {
             rb2D.GetComponent<Rigidbody2D>().bodyType=RigidbodyType2D.Dynamic;
         }
         else
         {
             rb2D.GetComponent<Rigidbody2D>().bodyType=RigidbodyType2D.Static;
         }
     }
 }