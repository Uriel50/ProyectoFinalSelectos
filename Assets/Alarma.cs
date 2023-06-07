using UnityEngine;

public class Alarma : MonoBehaviour
{
    public AudioClip sirenaClip;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Invocar el método para iniciar la sirena después de 20 segundos
        Invoke("IniciarSirena", 15f);
    }

    private void IniciarSirena()
    {
        // Verificar si el audio source y el clip están configurados correctamente
        if (audioSource != null && sirenaClip != null)
        {
            // Reproducir el sonido de la sirena de alarma
            audioSource.clip = sirenaClip;
            audioSource.Play();
        }
    }
}
