using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellController : MonoBehaviour
{
    public ParticleSystem shellExplosion;


    void Start()
    {
        
    }


    void Update()
    {
        
    }


    void OnCollisionEnter(Collision collision)
    {
        ParticleSystem fire = Instantiate(shellExplosion, transform.position, Quaternion.identity);
        fire.Play();
        
        Destroy(gameObject);
        Destroy(fire.gameObject, 2);
    }
}
