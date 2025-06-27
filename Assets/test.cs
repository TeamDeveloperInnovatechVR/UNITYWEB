using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        // Solo muestra si hay algún valor (evita mostrar 0 constantemente)
        if (verticalInput != 0)
        {
            Debug.Log("Input Vertical: " + verticalInput);
        }
    }
}
