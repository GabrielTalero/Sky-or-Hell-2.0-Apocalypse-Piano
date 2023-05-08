using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject GameObject;

    public AudioClip[] voices;

    public GameObject[] teclasPiano;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            audioSource.PlayOneShot(voices[0]);
            //teclasPiano.
        }
        else if (Input.GetKeyDown(KeyCode.S)) {
            audioSource.PlayOneShot(voices[1]);
        }
        else if (Input.GetKeyDown(KeyCode.D)) {
            audioSource.PlayOneShot(voices[2]);
        }
        else if (Input.GetKeyDown(KeyCode.F)) {
            audioSource.PlayOneShot(voices[3]);
        }
        else if (Input.GetKeyDown(KeyCode.G)) {
            audioSource.PlayOneShot(voices[4]);
        }
        else if (Input.GetKeyDown(KeyCode.H)) {
            audioSource.PlayOneShot(voices[5]);
        }
        else if (Input.GetKeyDown(KeyCode.J)) {
            audioSource.PlayOneShot(voices[6]);
        }
        else if (Input.GetKeyDown(KeyCode.K)) {
            audioSource.PlayOneShot(voices[7]);
        }
        else if (Input.GetKeyDown(KeyCode.L)) {
            audioSource.PlayOneShot(voices[8]);
        }
        else if (Input.GetKeyDown(KeyCode.BackQuote)) {
            audioSource.PlayOneShot(voices[9]);
        }
        else if(Input.GetKeyDown(KeyCode.W)) {
            audioSource.PlayOneShot(voices[10]);
        }
        else if(Input.GetKeyDown(KeyCode.E)) {
            audioSource.PlayOneShot(voices[11]);
        }
        else if(Input.GetKeyDown(KeyCode.T)) {
            audioSource.PlayOneShot(voices[12]);
        }
        else if(Input.GetKeyDown(KeyCode.Y)) {
            audioSource.PlayOneShot(voices[13]);
        }
        else if(Input.GetKeyDown(KeyCode.U)) {
            audioSource.PlayOneShot(voices[14]);
        }
        else if(Input.GetKeyDown(KeyCode.O)) {
            audioSource.PlayOneShot(voices[15]);
        }
        else if(Input.GetKeyDown(KeyCode.P)) {
            audioSource.PlayOneShot(voices[16]);
        }
    }
}
