using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    int delay = 1; //This implies a delay of 2 seconds.
    public float speed;
    public Rigidbody rb;

    void Start()
    {
        rb.velocity = Vector3.forward * speed;
        Destroy(gameObject,delay);
    }

    // Update is called once per frame
   public void OnCollisionEnter(Collision hit ){
       if (hit.gameObject.tag != "Enemy"){ Eliminarobjeto();
       return; }//this checks if the object you hit is a
       //transform tagged "Enemy"
       
       Eliminarobjeto();
   }
    private void Eliminarobjeto()  {
        Destroy((this.gameObject));
    }
  

}
 

