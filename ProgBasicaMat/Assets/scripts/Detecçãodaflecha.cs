﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detecçãodaflecha : MonoBehaviour
{

    bool teveColisao;
    public GameObject flecha;
    public Transform spawn;
    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        OnTriggerEnter2D(col.collider);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            teveColisao = true;
            anim.SetTrigger("atirou");

            Invoke("atira",0.5f);
            

        }
    }

    void atira()
    {
        Instantiate(flecha, spawn.position, spawn.rotation);
    }

}
