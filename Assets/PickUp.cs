using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Puerta"))
        {
            //comunicarse con el script de la puerta y activar apertura de puerta
            other.GetComponent<RotateBothDirections>().UseDoor();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Puerta"))
        {
            //comunicarse con el script de la puerta y activar apertura de puerta
            other.GetComponent<RotateBothDirections>().UseDoor();
        }
    }

}
