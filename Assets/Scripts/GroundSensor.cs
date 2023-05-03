using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    private PlayerControler controler;
    public bool isGrounded;
    
   SFXManager sfxManager;
   SoundManager soundManager;
   //GameManager gameManager;

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
        
         else if(other.gameObject.layer == 6)
        {
            Destroy(other.gameObject);
            Debug.Log("Enemy muerto");

            sfxManager.EnemyDeath();
            
           
           /*Enemy enemy = other.gameObject.GetComponent<Enemy>();
           enemy.Die();*/

        }
   }

    void OnTriggerStay2D(Collider2D other)
   {
        if(other.gameObject.layer == 3)
        {
            isGrounded = true;
            controler.anim.SetBool("IsJumping", false);
        }

   }

   void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
            isGrounded = false;
            controler.anim.SetBool("IsJumping", true);
        }
       
    }
  

}
