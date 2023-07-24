using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Pantalla : MonoBehaviour
{
    public TextMeshProUGUI textoUI; 
    private void Start()
    {
        if (PlayerPrefs.GetString("pantalla").Equals(""))
        {
            PlayerPrefs.SetString("pantalla", "pantalla completa");
        }
    textoUI.text = PlayerPrefs.GetString("pantalla");
        
    }
    // Start is called before the first frame update
    private void ConfigPantalla()
    {
        if (textoUI.text.Equals("pantalla completa"))
        {

            PlayerPrefs.SetString("pantalla", "ventana");
            textoUI.text = PlayerPrefs.GetString("pantalla");
            Screen.fullScreen=false;
        }
        if (textoUI.text.Equals("ventana"))
        {
         PlayerPrefs.SetString("pantalla","pantalla completa");
            textoUI.text = PlayerPrefs.GetString("pantalla");
            Screen.fullScreen = true;
        }

    }

    // Update is called once per frame

}
