using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayer : MonoBehaviour
{
    public float xAxis;
    public float zAxis;
    public float usarHabilidad;
    public int playerNo;
    public bool bButtonDown;
    public float xAxisRightStick;
    public bool rightStickBup;
    public bool rightStickBdown;
    public bool soyXbox;
    public float deteccionXAxis;
    public float deteccionZAxis;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (playerNo) //Segun el player que somos (playerNo) es el input que usamos.
        {
            case 1:
                if (soyXbox)
                {
                    xAxis = Input.GetAxis("Xbox1LHorizontal");
                    zAxis = Input.GetAxis("Xbox1LVertical");
                    usarHabilidad = Input.GetAxis("Xbox1RTAxis");
                    deteccionXAxis = Input.GetAxisRaw("Xbox1LHorizontal");
                    deteccionZAxis = Input.GetAxisRaw("Xbox1LVertical");
                    bButtonDown = Input.GetKeyDown(KeyCode.Joystick1Button1);
                    xAxisRightStick = Input.GetAxis("Xbox1RHorizontal");
                    rightStickBup = Input.GetKeyUp(KeyCode.Joystick1Button9);
                    rightStickBdown = Input.GetKeyDown(KeyCode.Joystick1Button9);
                }
                else if (!soyXbox)
                {
                    xAxis = Input.GetAxis("PS1LHorizontal");
                    zAxis = Input.GetAxis("PS1LVertical");
                    usarHabilidad = Input.GetAxis("PS1R2Axis");
                    deteccionXAxis = Input.GetAxisRaw("PS1LHorizontal");
                    deteccionZAxis = Input.GetAxisRaw("PS1LVertical");
                    bButtonDown = Input.GetKeyDown(KeyCode.Joystick1Button2);
                    xAxisRightStick = Input.GetAxis("PS1RHorizontal");
                    rightStickBup = Input.GetKeyUp(KeyCode.Joystick1Button11);
                    rightStickBdown = Input.GetKeyDown(KeyCode.Joystick1Button11);
                }

                break;
        }
    }
}
