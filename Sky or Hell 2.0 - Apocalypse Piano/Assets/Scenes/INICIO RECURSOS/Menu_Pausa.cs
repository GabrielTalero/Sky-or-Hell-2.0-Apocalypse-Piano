using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Pausa : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject Atras;
    public GameObject Pausa;
    public GameObject Sonido;

    public void PausaBoton(){
        pauseMenu.SetActive(true);
        Atras.SetActive(false);
        Pausa.SetActive(false);
        Sonido.SetActive(false);
        Time.timeScale = 0;
    }


    public void playButton(){
        pauseMenu.SetActive(false);
        Atras.SetActive(true);
        Pausa.SetActive(true);
        Sonido.SetActive(true);
        Time.timeScale = 1;
    }

    private bool paused = false;

   private void Update(){
    if (Input.GetKeyDown(KeyCode.Escape)){
        if(paused){
            playButton();
            ResumeSonido();
            paused = false;

             /*foreach(AudioSource a in audioSources){
             a.Play();
            }*/



        } else {
            PausaBoton();
            StopSonido();
            paused = true;
         }
        }
    }

    private List<AudioSource> pausedAudioSources = new List<AudioSource>();
    private bool SonidoBoton = true;

    public void StopSonido(){

         if(SonidoBoton){
            AudioSource[] audioSources = FindObjectsOfType<AudioSource>();
        // Detener todos los sonidos AudioSource y agregarlos a la lista pausedAudioSources
        foreach(AudioSource audioSource in audioSources){
            if(audioSource.isPlaying){
                audioSource.Stop();
                pausedAudioSources.Add(audioSource);
            }
        }
        SonidoBoton = false;
    } else {
        ResumeSonido();
        SonidoBoton = true;
    }

    
    }

    public void ResumeSonido(){
        // Reanudar todos los sonidos AudioSource en la lista pausedAudioSources
        foreach(AudioSource audioSource in pausedAudioSources){
            audioSource.Play();
        }
        
        // Limpiar la lista pausedAudioSources
        pausedAudioSources.Clear();
        // Reiniciar SonidoBoton a true
        SonidoBoton = true;
    }



}
