using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    //private Rigidbody _rb;
    //public float velocidad = 1;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    _rb = GetComponent<Rigidbody>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    _rb.AddForce(new Vector3(velocidad,0,0),ForceMode.Acceleration);
    //}
    public float velocidadMov = 1;
    public float velocidadRot = 1;
    [SerializeField] private Rigidbody _rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direcion = transform.right * -Input.GetAxis("Vertical");
        //if (Input.GetKey(KeyCode.W))
        //{
        //    Movement(direcion);
        //}
        //else if (Input.GetKey(KeyCode.S))
        //{
        //    Movement(-direcion);
        //}
        Movement(direcion);
        Rotacion();
    }
    private void Movement(Vector3 direcion)
    {
        _rb.AddForce(direcion * velocidadMov * Time.deltaTime);
    }
    private void Rotacion()
    {
        _rb.AddTorque(new Vector3(0, Input.GetAxis("Horizontal"), 0) * velocidadRot * Time.deltaTime);
    }
}
