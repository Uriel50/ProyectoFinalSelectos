using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecorridoCamara : MonoBehaviour
{
    public Transform[] waypoints;
    public ST_PuzzleDisplay puzzleDisplay;
    public float velocidad = 2f;
    public bool Complete = false; // Variable para detener la cámara en el tercer waypoint
    public bool FinRecorrido = false;
    private int indiceActual = 0;

    private void Start()
    {
        // Asegurarse de que al menos haya un waypoint asignado
        if (waypoints.Length > 0)
        {
            // Mover la cámara al primer waypoint al inicio
            transform.position = waypoints[0].position;
        }
    }

    private void Update()
    {
        // Asegurarse de que haya más de un waypoint asignado
        if (waypoints.Length > 1)
        {
            // Obtener la posición del waypoint actual y del siguiente
            Vector3 posicionActual = waypoints[indiceActual].position;
            Vector3 posicionSiguiente = waypoints[(indiceActual + 1) % waypoints.Length].position;

            // Calcular la dirección y distancia al siguiente waypoint
            Vector3 direccion = (posicionSiguiente - posicionActual).normalized;
            float distancia = Vector3.Distance(posicionActual, posicionSiguiente);

            if (indiceActual == 2 && !puzzleDisplay.Complete)
            {
                // Detener la cámara en el tercer waypoint si Complete es false
                transform.position = posicionActual;
            }
            else
            {
                // Mover la cámara hacia el siguiente waypoint
                transform.position += direccion * velocidad * Time.deltaTime;
            }

            // Si la cámara alcanza o supera el siguiente waypoint
            if (Vector3.Distance(transform.position, posicionActual) >= distancia)
            {
                // Comprobar si es el último waypoint
                if (indiceActual == waypoints.Length - 2)
                {
                    // Detener la cámara en el último waypoint
                    transform.position = posicionSiguiente;

                    FinRecorrido=true;

                }
                else
                {
                    // Avanzar al siguiente waypoint
                    indiceActual = (indiceActual + 1) % waypoints.Length;
                }
            }
        }
    }
}
