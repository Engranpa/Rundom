using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampaRetroceso : MonoBehaviour
{
    PlayerController player;
    public float unidades;
    private float velocidadPlayer;
    public float tiempo;
    public bool trampaActivada;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trampaActivada)
        {
            Retroceder();
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = other.GetComponent<PlayerController>();
            velocidadPlayer = player.velocidad;
            player.rb.velocity = Vector3.zero;
            player.velocidad = 0;
            trampaActivada = true;
            Invoke("DesactivarTrampa", tiempo);
        }
    }

    private void Retroceder()
    {
        player.transform.Translate(Vector3.forward * -1 * (unidades * 0.01f),Space.Self);
        player.inputPlayer.enabled = false;
    }

    private void DesactivarTrampa()
    {
        trampaActivada = false;
        player.velocidad = velocidadPlayer;
        player.inputPlayer.enabled = true;
    }

    
}
