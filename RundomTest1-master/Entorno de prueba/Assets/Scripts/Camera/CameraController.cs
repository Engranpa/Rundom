using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 distanciaDelPlayer;
    public bool moverHorizontal;
    public bool escenarioLineal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Si queremos que la camara se mueva en el eje horizontal con respecto al personaje o no.
        if (moverHorizontal)
        {
            transform.position = player.position + distanciaDelPlayer;
        }
        else //Si no queremos eso, congelamos el movimiento en ese eje dejandolo en 0.
        {
            transform.position = new Vector3(0, player.position.y, player.position.z) + distanciaDelPlayer;
        }


        //Aca es si el escenario no es lineal, es decir si es circular.
        if (!escenarioLineal)
        {
            //Codear el funcionamiento de la camara en función de la otra pista.
        }
    }
}
