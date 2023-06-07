using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRotation : MonoBehaviour
{
    public ST_PuzzleDisplay puzzleDisplay;
    public float rotationSpeed = 90f;
    public bool completo;

    private Quaternion targetRotation;
    private bool doorOpened = false;

    private void Start()
    {
        // Guarda la rotación inicial de la puerta
        targetRotation = transform.rotation;
    }

    private void Update()
    {   
        // Verifica si el puzzle está completo y la puerta aún no se ha abierto
        if (puzzleDisplay.Complete && !doorOpened)
        {

            // Rota gradualmente la puerta en el eje Z
            RotateDoor();
            doorOpened=true;

            // Verifica si la puerta ha alcanzado la rotación objetivo

            completo=doorOpened;
        }
    }
    private void RotateDoor()
    {
        transform.Rotate(0f, 0f, 90f);
    }
}

