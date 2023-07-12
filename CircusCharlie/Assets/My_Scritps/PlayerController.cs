using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 700f;
    private int jumpCount = 0;
    private bool isGrounded = false;

    public int playerLife = 3;




    private Rigidbody2D playerRigidBody;
    private Animator animator;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        float xInput = Input.GetAxis("Horizontal");
        float xSpeed = xInput * speed;


        Vector3 newVelocity = new Vector3(xSpeed, 0, 0);
        playerRigidBody.velocity = newVelocity;
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && jumpCount == 0 && isGrounded)
        {
            playerRigidBody.velocity = Vector2.zero;
            playerRigidBody.AddForce(new Vector2(0f, jumpForce));
            //playerRigidBody.AddForce(Vector3.up*jumpForce, ForceMode2D.Force);
            Debug.Log("°øÁß¿¡ ¶ä");
            jumpCount++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            isGrounded = true;
            jumpCount = 0;
            Debug.Log("¹Ù´Ú¿¡ ´êÀ½");
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            isGrounded = false;
            Debug.Log("¹Ù´Ú¿¡¼­ ¶ß±â ½ÃÀÛÇÔ");
        }
    }

    public void Die()
    {
        if (playerLife == 0)
        { 
            // »ç¸Á ·ÎÁ÷ Ã³¸®    
        }
    }
}
