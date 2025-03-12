using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionTorreta : MonoBehaviour
{
    public float velocidadRotacion = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            RotarCannon(-1);
        }
        if (Input.GetKey(KeyCode.E))
        {
            RotarCannon(1);
        } 
    }
    private void RotarCannon(float direccion)
    {
        transform.Rotate(0,direccion * velocidadRotacion,0);
    }

}
