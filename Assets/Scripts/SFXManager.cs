using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioClip playerDeath;
    public AudioClip prop;
    public AudioClip attack;
    public AudioClip propOut;
    public AudioClip enemyDeath;

    private AudioSource source;
    // Start is called before the first frame update
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

 
    public void PlayerDeath()
    {
        source.PlayOneShot(playerDeath);
    }

    public void Prop()
    {
        source.PlayOneShot(prop);
    }

    public void Attack()
    {
        source.PlayOneShot(attack);
    }

    public void PropOut()
    {
        source.PlayOneShot(propOut);
    }

    public void EnemyDeath()
    {
        source.PlayOneShot(enemyDeath);
    }
}
