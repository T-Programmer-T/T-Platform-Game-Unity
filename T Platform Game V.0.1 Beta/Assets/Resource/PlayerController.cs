using System.Collections;

using System.Collections.Generic;

using TMPro;

using UnityEngine;

public class PlayerController : MonoBehaviour { 

    public float Jump;

    public bool isGround = false;

    public GameObject bulletPrefabs;

    public bool isLeft = false;

    void Start()
 
    {


    }

    void Update()

    {
        if (Input.GetKey(KeyCode.RightArrow))

        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            
            Animator anim = GetComponent<Animator>();
            
            rb.velocity = new Vector2(5, rb.velocity.y);
            
            anim.SetFloat("Speed",5);
            
            transform.localScale = new Vector3(0.3f, 0.3f,1);

            isLeft = false;


        }
        
        else if (Input.GetKey(KeyCode.LeftArrow))
        
        {
            
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            
            Animator anim = GetComponent<Animator>();
            
            rb.velocity = new Vector2(-5,rb.velocity.y);
            
            anim.SetFloat("Speed",5);
            
            transform.localScale = new Vector3(-0.3f, 0.3f, 1);

            isLeft = true;


        }

        else
        
        {
            
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            
            Animator anim = GetComponent<Animator>();
            
            rb.velocity = new Vector2(0, rb.velocity.y);
            
            anim.SetFloat("Speed", 0);
        
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && isGround)

        {
            
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            
            rb.AddForce(new Vector2(0,Jump));
            
            Animator anim = GetComponent<Animator>();
            
            anim.Play("Player Jump Anim");
            
            transform.localScale = new Vector3(-0.3f, 0.3f, 1);
        
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }

    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefabs, transform.position, Quaternion.identity);
        if (isLeft)
        {
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(-10, 0);
        }
        else
        {
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(10, 0);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    
    {
        
        if (collision.gameObject.tag == "Ground")
        
        {

            isGround = true;

        }
    
    }

        private void OnCollisionExit2D(Collision2D collision)
       
        {
            if (collision.gameObject.tag == "Ground")
            {

                isGround = false;

            }
        
        }

}

