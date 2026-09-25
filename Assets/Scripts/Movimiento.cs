using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private Rigidbody rb;

    public float velocidad = 5f;
    public Transform camara;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");

        Vector3 adelante = camara.forward;
        Vector3 derecha = camara.right;

        adelante.y = 0f;
        derecha.y = 0f;

        adelante.Normalize();
        derecha.Normalize();

 
        Vector3 movimiento = adelante * movimientoV + derecha * movimientoH;

        rb.AddForce(movimiento * velocidad);
    }
}
