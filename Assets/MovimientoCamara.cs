using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    private bool explosionActiva = false;
    public Vector3 posicionInicial;

    private void Start()
    {

        // Invocar el método para iniciar la explosión después de 15 segundos
        Invoke("IniciarExplosion", 28f);
    }

    private void IniciarExplosion()
    {
        // Iniciar una coroutina para controlar el movimiento de la cámara durante 3 segundos
        StartCoroutine(EfectoExplosion());
    }

    private IEnumerator EfectoExplosion()
    {
        // Activar el efecto de explosión
        explosionActiva = true;

        // Mover la cámara durante 3 segundos
        float tiempoInicio = Time.time;
        while (Time.time - tiempoInicio < 3f)
        {
            // Aquí puedes ajustar la lógica de movimiento de la cámara según tus necesidades.
            // Por ejemplo, puedes usar el método Translate para desplazar la cámara.

            // En este ejemplo, simplemente hacemos que la cámara se mueva en una dirección aleatoria.
            Vector3 movimiento = new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f), Random.Range(-3f, 3f));
            transform.Translate(movimiento * Time.deltaTime);

            yield return null;
        }

        // Restaurar la posición inicial de la cámara después de finalizar el efecto de explosión
        transform.position = posicionInicial;
        explosionActiva = false;
    }
}
