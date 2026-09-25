using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform jugador;

    [Header("Distancia")]
    public Vector3 distancia = new Vector3(8f, 10f, -8f);

    [Header("Suavidad")]
    public float suavidad = 5f;

    void LateUpdate()
    {
        if (jugador == null)
            return;


        Vector3 posicionObjetivo = jugador.position + distancia;

        transform.position = Vector3.Lerp(
            transform.position,
            posicionObjetivo,
            suavidad * Time.deltaTime);
        transform.LookAt(jugador);
    }
}