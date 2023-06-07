using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giro : MonoBehaviour
{
    public float rotationSpeed = 10f; // Velocidad de rotación en grados por segundo

    // Update es llamado una vez por frame
    void Update()
    {
        // Obtener la rotación actual del objeto
        Vector3 rotation = transform.rotation.eulerAngles;

        // Calcular la nueva rotación del objeto
        float newRotation = rotation.y + rotationSpeed * Time.deltaTime;

        // Aplicar la rotación al objeto
        transform.rotation = Quaternion.Euler(0, newRotation, 0);
    }
}
