using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pausa : MonoBehaviour
{
    public AudioSource audioSource2;
    public GameObject pantallaPausa;
    public GameObject musikk;
    // Start is called before the first frame update
    private void Start()
    { 
    
    audioSource2 = FindObjectOfType<AudioSource>();
   if (SceneManager.GetActiveScene().buildIndex == 0)
        {
           Destroy(musikk);
        }
    
    }
        public void ActivaPausa()
    {

        if (pantallaPausa.activeSelf)
        {

            pantallaPausa.SetActive(false);
            Time.timeScale = 1f;
            audioSource2.Play();
        }
        else
        {
            pantallaPausa.SetActive(true);
            Time.timeScale = 0f;
            audioSource2.Stop();
        }
    }


    void Update()
    { 

    }
    // Update is called once per frame
}
