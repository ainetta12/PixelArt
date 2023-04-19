using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    private PlayerControler controler;
    public bool isGrounded;
     void Awake()
    {
        controler = GetComponentInParent<PlayerControler>();

    }

   void OnTriggerEnter2D(Collider2D other)
   {
        if(other.gameObject.layer == 3)
        {
            isGrounded = true;
        }


    void OnTriggerStay2D(Collider2D other)
   {
        if(other.gameObject.layer == 3)
        {
            isGrounded = true;
            //controler.anim.SetBool("IsJumping", false);
        }

   }

   void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
            isGrounded = false;
            //controler.anim.SetBool("IsJumping", true);
        }
       
    }
  
  } 

}
