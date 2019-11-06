using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public InputPlayer inputPlayer;
    public Rigidbody rb;
    public float velocidad;
    
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;

    
    // Start is called before the first frame update
    void Start()
    {
        inputPlayer = GetComponent<InputPlayer>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {  //codigo para disparar
        
       
            if (Input.GetButton("Fire1") && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            }
        
    }

    private void FixedUpdate()
    {
        //Se usan fisicas para mover el jugador, usando el InputPlayer y los Atributos para la velocidad, sin modificar el eje Y.
        rb.velocity = new Vector3(inputPlayer.xAxis * velocidad, rb.velocity.y, inputPlayer.zAxis * velocidad * -1) * Time.deltaTime;

        

        //Se usa el LookAt para que el objeto se rote en funcion de la direccion a la que movemos el analogico.
        transform.LookAt(transform.position + Vector3.forward);
        
        //agrego partes de codigo para movelo con las flechas.
        
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * velocidad);
    }

    public void Disparar()
    {
        
        
    }
}
