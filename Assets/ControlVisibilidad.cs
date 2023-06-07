using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlVisibilidad : MonoBehaviour
{
    public RecorridoCamara recorridoCamara; // Referencia al script RecorridoCamara
    public GameObject objetoMostrarOcultar; // Objeto a mostrar u ocultar

    private void Update()
    {
        // Verificar el valor de la variable FinRecorrido en el script RecorridoCamara
        if (recorridoCamara.FinRecorrido)
        {
            // Mostrar el objeto
            objetoMostrarOcultar.SetActive(true);
        }
        else
        {
            // Ocultar el objeto
            objetoMostrarOcultar.SetActive(false);
        }
    }
}

