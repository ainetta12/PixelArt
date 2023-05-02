using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    int playerHealth = 3;
    public float playerSpeed = 5.5f;
    public float jumForce = 3f;

    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rBody;
    private GroundSensor sensor;
    public Animator anim;
    private Prop prop;

    float horizontal;
    GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sensor = GameObject.Find ("GroundSensor").GetComponent<GroundSensor>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    
        //transform.position += new Vector3(horizontal, 0, 0) * playerSpeed * Time.deltaTime;

        if(horizontal < 0)
        {
            //spriteRenderer.flipX = true; 
            transform.rotation = Quaternion.Euler(0, 180, 0);
            anim.SetBool("IsRunning", true);
        }

        else if(horizontal > 0)
        {
             //spriteRenderer.flipX = false;
             transform.rotation = Quaternion.Euler(0, 0, 0);
             anim.SetBool("IsRunning", true);
        }
        else
        {
             anim.SetBool("IsRunning", false);
        }

        if(Input.GetButtonDown("Jump") && sensor.isGrounded)
        {
            rBody.AddForce(Vector2.up * jumForce, ForceMode2D.Impulse);
            anim.SetBool("IsJumping", true);
        }

    }
    void FixedUpdate() 
    {
        rBody.velocity = new Vector2 (horizontal * playerSpeed, rBody.velocity.y);
    }


}
    

