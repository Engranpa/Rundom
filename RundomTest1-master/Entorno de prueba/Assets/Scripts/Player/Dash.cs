using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class Dash : MonoBehaviour
{  
   public Rigidbody rb= new Rigidbody();
   public float fuerza;
   public int countdash;
   
   void Update(){ if (Input.GetKeyDown(KeyCode.LeftShift) && countdash > 0)
      {

         rb.AddForce(Vector3.forward * fuerza, ForceMode.Impulse);
         
         
      }
      
   }

   
}
