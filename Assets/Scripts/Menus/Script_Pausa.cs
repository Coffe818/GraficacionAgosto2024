using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_Pausa : MonoBehaviour
{
    public GameObject panelPausa;
    public bool Pausa = false;
    public GameObject menuSalir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Pausa == false)
            {
                panelPausa.SetActive(true);
                menuSalir.SetActive(false);
                Pausa = true;

                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;

                // Quitar sonido de fondo cuando lo haya si es que lo hay
                // dentro del array van las fuentes de audio que se quieren detener
                // FindObjectsOfType<AudioSource>() busca todos los objetos con componente AudioSource en la escena
                AudioSource[] sonidos = FindObjectsOfType<AudioSource>();
                
                for (int i = 0; i < sonidos.Length; i++)
                {
                    sonidos[i].Pause();
                }
            }
            else if(Pausa == true) 
            {
                Resume();
            }
        }
    }

    public void Resume()
    {
        panelPausa.SetActive(false);
        Pausa = false;

        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        // Reanudar audio
        AudioSource[] sonidos = FindObjectsOfType<AudioSource>();

        for (int i = 0; i < sonidos.Length; i++)
        {
            sonidos[i].Play();
        }
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("MenuInicio");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
