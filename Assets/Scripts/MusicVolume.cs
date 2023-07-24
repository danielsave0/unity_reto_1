using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MusicVolume : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider volumeSlider;

    private void Start()
    {
        // Asegurarse de que el objeto tenga un componente AudioSource asignado.
        if (audioSource == null)
        {
            audioSource = FindObjectOfType<AudioSource>();
            if (audioSource == null)
            {
                Debug.LogWarning("No se encontró ningún componente AudioSource en la escena.");
                return;
            }
        }

        // Asegurarse de que el objeto tenga un componente Slider asignado.
        if (volumeSlider == null)
        {
            volumeSlider = GetComponent<Slider>();
            if (volumeSlider == null)
            {
                Debug.LogWarning("No se encontró ningún componente Slider en el objeto AudioSliderController.");
                return;
            }
        }

        // Obtener el valor inicial del volumen del AudioSource y configurar el Slider en consecuencia.
        volumeSlider.value = audioSource.volume;
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    private void ChangeVolume(float volume)
    {
        // Cambiar el volumen del AudioSource según el valor del Slider.
        audioSource.volume = volume;
    }
}
