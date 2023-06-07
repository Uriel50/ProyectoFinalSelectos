using UnityEngine;

public class MovimientoAvion : MonoBehaviour
{
    public float velocidad = 20f;
    public float amplitud = 5f;
    public float frecuencia = 1f;
    public Transform posicionFinal;

    private Vector3 posicionInicial;
    private float tiempoInicio;
    private bool iniciarMovimiento = false;

    private void Start()
    {
        posicionInicial = transform.position;
        tiempoInicio = Time.time;

        // Invocar el método para iniciar el movimiento después de 25 segundos
        Invoke("IniciarMovimiento", 40f);
    }

    private void IniciarMovimiento()
    {
        iniciarMovimiento = true;
    }

    private void Update()
    {
        if (!iniciarMovimiento)
            return;

        // Calcular la posición vertical del avión utilizando una función sinusoidal
        float posY = posicionInicial.y + amplitud * Mathf.Sin((Time.time - tiempoInicio) * frecuencia);

        // Mover el avión hacia adelante con una velocidad constante
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);

        // Establecer la nueva posición del avión
        transform.position = new Vector3(transform.position.x, posY, transform.position.z);

        // Verificar si el avión ha alcanzado la posición final
        if (iniciarMovimiento)
        {
            // Realizar alguna acción al llegar a la posición final, como detener el movimiento, reproducir una animación, etc.
            // Aquí puedes agregar tu lógica personalizada.
            // Por ejemplo, podrías desactivar el script o detener el movimiento del avión.
            if(Time.time >= 70f){
                iniciarMovimiento = false;
            }
            // Detener el movimiento del avión
            
        }
    }
}
