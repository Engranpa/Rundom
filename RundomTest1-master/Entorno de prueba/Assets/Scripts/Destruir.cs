using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    public int vida;
    public int daño;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Damage()
    {
        vida = vida - daño;

        if (vida == 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void OnCollisionEnter(Collision hit ){
        if (hit.gameObject.tag == "Bullet"){ 
            Damage();
        }
    }
    }

