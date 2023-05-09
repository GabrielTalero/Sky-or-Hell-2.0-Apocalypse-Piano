using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayMusic : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject GameObject;

    public AudioClip[] voices;

    public GameObject[] teclasPiano;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            audioSource.PlayOneShot(voices[0]);
            StartCoroutine(ChangeColorCoroutine(0, Color.grey, 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            audioSource.PlayOneShot(voices[1]);
            StartCoroutine(ChangeColorCoroutine(1, Color.grey, 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            audioSource.PlayOneShot(voices[2]);
            StartCoroutine(ChangeColorCoroutine(2, Color.grey, 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            audioSource.PlayOneShot(voices[3]);
            StartCoroutine(ChangeColorCoroutine(3, Color.grey, 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            audioSource.PlayOneShot(voices[4]);
            StartCoroutine(ChangeColorCoroutine(4, Color.grey, 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            audioSource.PlayOneShot(voices[5]);
            StartCoroutine(ChangeColorCoroutine(5, Color.grey, 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            audioSource.PlayOneShot(voices[6]);
            StartCoroutine(ChangeColorCoroutine(6, Color.grey, 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            audioSource.PlayOneShot(voices[7]);
            StartCoroutine(ChangeColorCoroutine(7, Color.grey, 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            audioSource.PlayOneShot(voices[8]);
            StartCoroutine(ChangeColorCoroutine(8, Color.grey, 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            audioSource.PlayOneShot(voices[9]);
            StartCoroutine(ChangeColorCoroutine(9, Color.grey, 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            audioSource.PlayOneShot(voices[10]);
            StartCoroutine(ChangeColorCoroutine(10, Color.black, 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            audioSource.PlayOneShot(voices[11]);
            StartCoroutine(ChangeColorCoroutine(11, Color.black, 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            audioSource.PlayOneShot(voices[12]);
            StartCoroutine(ChangeColorCoroutine(12, Color.black, 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            audioSource.PlayOneShot(voices[13]);
            StartCoroutine(ChangeColorCoroutine(13, Color.black, 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            audioSource.PlayOneShot(voices[14]);
            StartCoroutine(ChangeColorCoroutine(14, Color.black, 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            audioSource.PlayOneShot(voices[15]);
            StartCoroutine(ChangeColorCoroutine(15, Color.black, 0.5f));
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            audioSource.PlayOneShot(voices[16]);
            StartCoroutine(ChangeColorCoroutine(16, Color.black, 0.5f));
        }

    }

    IEnumerator ChangeColorCoroutine(int index, Color color, float delay)
    {
        teclasPiano[index].GetComponent<Image>().color = color;
        yield return new WaitForSeconds(delay);
        teclasPiano[index].GetComponent<Image>().color = Color.white; // Cambiar de nuevo al color original
    }
}