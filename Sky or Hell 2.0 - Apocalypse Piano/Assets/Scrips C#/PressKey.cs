using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PressKey : MonoBehaviour
{

    public Image myImage;
    public Color myColor;
    public Color myColor2;


    //Para reproducir mp3
    private Dictionary<int, AudioClip> sonidos = new Dictionary<int, AudioClip>();
    private string rutaDeCarpeta = "Assets/Material/pianoNotesAll";


    // Start is called before the first frame update
    private void Start()
    {
        myColor.a=1;
        myColor2.a=1;


        // Cargar los archivos de sonido desde la carpeta Resources
        string carpetaDeSonidos = Path.Combine(Application.dataPath, rutaDeCarpeta);

        for (int i = 30; i <= 90; i++)
        {
            string nombreArchivo = i.ToString();
            string rutaDeArchivo = Path.Combine(carpetaDeSonidos, nombreArchivo + ".mp3");
            AudioClip clip = LoadAudioClip(rutaDeArchivo);
            sonidos.Add(i, clip);
        }
    }


    public void OnClick()
    {

     myImage.color = myColor;

    ReproducirSonidoDelNumero(35);


    }


    // Cargar los archivos de sonido desde la carpeta Resources
    private AudioClip LoadAudioClip(string ruta)
    {
        // Cargar el archivo de sonido en un AudioClip
        WWW loader = new WWW("file://" + ruta);
        while (!loader.isDone) { }

        return loader.GetAudioClip(false);
    }

    public void ReproducirSonidoDelNumero(int numero)
    {
        if (sonidos.ContainsKey(numero))
        {
            Debug.Log("Tecla " + numero);
            
            AudioClip clip = sonidos[numero];
            //AudioSource.PlayClipAtPoint(clip, transform.position);
            
            GetComponent<AudioSource>().PlayOneShot(clip);
            
        }
    }
    void Update ()
    {
        myImage.color = myColor2; 
    }
}
