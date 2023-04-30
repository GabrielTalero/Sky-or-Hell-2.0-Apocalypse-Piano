using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ReproducirSonido : MonoBehaviour
{

    //Para reproducir mp3
    private Dictionary<int, AudioClip> sonidos = new Dictionary<int, AudioClip>();
    private string rutaDeCarpeta = "Assets/Material/pianoNotesAll";

    // Start is called before the first frame update
    void Start()
    {
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
        Debug.Log("Tecla " + numero);
        if (sonidos.ContainsKey(numero))
        {
            Debug.Log("Tecla " + numero);
            AudioClip clip = sonidos[numero];
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
