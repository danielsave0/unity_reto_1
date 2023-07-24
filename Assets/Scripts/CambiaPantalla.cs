using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CambiaPantalla : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1f;
       AudioSource audioSource2 = FindObjectOfType<AudioSource>();
        audioSource2.Play();
    }
    public int scena;
   public void Clic()
    {
        SceneManager.LoadScene(scena);

    }
    public void ReloadScena()
    {
       int sceneName = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneName);
    }
}
