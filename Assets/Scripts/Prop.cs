using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : MonoBehaviour
{
    Animator anim;
    BoxCollider2D boxCollider;
    SFXManager sfxManager;
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void Die()
    {
        boxCollider.enabled = false;
        sfxManager.Prop();
        gameManager.AddProp();
        Destroy(this.gameObject);
    }
}
