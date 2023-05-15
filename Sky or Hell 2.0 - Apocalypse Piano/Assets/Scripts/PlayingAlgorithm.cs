using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using MidiJack;

public class PlayingAlgorithm : MonoBehaviour
{

    public AudioSource audioSource;
    public GameObject GameObject;

    public AudioClip[] voices;

    public GameObject[] teclasPiano;

    string pianoKey, pianoKeyPC;
    private string[] notes;




    void Start()
    {
        string[] c = new string[12]
        {"C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        notes = new string[48];
        for (int i = 2; i < 6; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                notes[(i - 2) * 12 + j] = c[j] + i.ToString();
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        pianoKey = "*";

        int i = 36;


        if (Input.GetKeyDown(KeyCode.A))
        {
            ReproducirNotasPcPiano("A", 0);
            DestruirNota(notes[12]);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            ReproducirNotasPcPiano("S", 0);
            DestruirNota(notes[14]);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            ReproducirNotasPcPiano("D", 0);
            DestruirNota(notes[16]);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            ReproducirNotasPcPiano("F", 0);
            DestruirNota(notes[17]);
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            ReproducirNotasPcPiano("G", 0);
            DestruirNota(notes[19]);
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            ReproducirNotasPcPiano("H", 0);
            DestruirNota(notes[21]);
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            ReproducirNotasPcPiano("J", 0);
            DestruirNota(notes[23]);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            ReproducirNotasPcPiano("K", 0);
            DestruirNota(notes[24]);
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            ReproducirNotasPcPiano("L", 0);
            DestruirNota(notes[26]);
        }
        else if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            ReproducirNotasPcPiano("BackQuote", 0);
            DestruirNota(notes[28]);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            ReproducirNotasPcPiano("W", 0);
            DestruirNota(notes[13]);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            ReproducirNotasPcPiano("E", 0);
            DestruirNota(notes[15]);
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            ReproducirNotasPcPiano("T", 0);
            DestruirNota(notes[18]);
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            ReproducirNotasPcPiano("Y", 0);
            DestruirNota(notes[20]);
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            ReproducirNotasPcPiano("U", 0);
            DestruirNota(notes[22]);
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            ReproducirNotasPcPiano("O", 0);
            DestruirNota(notes[25]);
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            ReproducirNotasPcPiano("P", 0);
            DestruirNota(notes[27]);
        }


        for (; i < 84 && !MidiMaster.GetKeyDown(i); i++) ;
        if (i < 84)
        {
            pianoKey = notes[i - 36];

            BroadcastMessage("CheckNote", pianoKey);
            ReproducirNotasPcPiano("", i);
            /*if (Input.GetKeyDown(KeyCode.A) || i == 48) {
                audioSource.PlayOneShot(voices[0]);
                StartCoroutine(ChangeColorCoroutine(0, Color.grey, 0.5f));
            }*/
            Debug.Log(i - 36);
            //Debug.Log(pianoKey + "playingAlgorithm");
        }
    }


    void DestruirNota(object pianoKeyPC)
    {
        BroadcastMessage("CheckNote", pianoKeyPC);
    }

    void ReproducirNotasPcPiano(string letra, int piano)
    {
        if (letra.Equals("A") || piano == 48)
        {
            audioSource.PlayOneShot(voices[0]);
            StartCoroutine(ChangeColorCoroutine(0, Color.grey, 0.5f));
            BroadcastMessage("CheckNote", pianoKey);
        }
        else if (letra.Equals("S") || piano == 50)
        {
            audioSource.PlayOneShot(voices[1]);
            StartCoroutine(ChangeColorCoroutine(1, Color.grey, 0.5f));
        }
        else if (letra.Equals("D") || piano == 52)
        {
            audioSource.PlayOneShot(voices[2]);
            StartCoroutine(ChangeColorCoroutine(2, Color.grey, 0.5f));
        }
        else if (letra.Equals("F") || piano == 53)
        {
            audioSource.PlayOneShot(voices[3]);
            StartCoroutine(ChangeColorCoroutine(3, Color.grey, 0.5f));
        }
        else if (letra.Equals("G") || piano == 55)
        {
            audioSource.PlayOneShot(voices[4]);
            StartCoroutine(ChangeColorCoroutine(4, Color.grey, 0.5f));
        }
        else if (letra.Equals("H") || piano == 57)
        {
            audioSource.PlayOneShot(voices[5]);
            StartCoroutine(ChangeColorCoroutine(5, Color.grey, 0.5f));
        }
        else if (letra.Equals("J") || piano == 59)
        {
            audioSource.PlayOneShot(voices[6]);
            StartCoroutine(ChangeColorCoroutine(6, Color.grey, 0.5f));
        }
        else if (letra.Equals("K") || piano == 60)
        {
            audioSource.PlayOneShot(voices[7]);
            StartCoroutine(ChangeColorCoroutine(7, Color.grey, 0.5f));
        }
        else if (letra.Equals("L") || piano == 62)
        {
            audioSource.PlayOneShot(voices[8]);
            StartCoroutine(ChangeColorCoroutine(8, Color.grey, 0.5f));
        }
        else if (letra.Equals("BackQuote") || piano == 64)
        {
            audioSource.PlayOneShot(voices[9]);
            StartCoroutine(ChangeColorCoroutine(9, Color.grey, 0.5f));
        }
        else if (letra.Equals("W") || piano == 49)
        {
            audioSource.PlayOneShot(voices[10]);
            StartCoroutine(ChangeColorCoroutine(10, Color.black, 0.5f));
        }
        else if (letra.Equals("E") || piano == 51)
        {
            audioSource.PlayOneShot(voices[11]);
            StartCoroutine(ChangeColorCoroutine(11, Color.black, 0.5f));
        }
        else if (letra.Equals("T") || piano == 54)
        {
            audioSource.PlayOneShot(voices[12]);
            StartCoroutine(ChangeColorCoroutine(12, Color.black, 0.5f));
        }
        else if (letra.Equals("Y") || piano == 56)
        {
            audioSource.PlayOneShot(voices[13]);
            StartCoroutine(ChangeColorCoroutine(13, Color.black, 0.5f));
        }
        else if (letra.Equals("U") || piano == 58)
        {
            audioSource.PlayOneShot(voices[14]);
            StartCoroutine(ChangeColorCoroutine(14, Color.black, 0.5f));
        }
        else if (letra.Equals("O") || piano == 61)
        {
            audioSource.PlayOneShot(voices[15]);
            StartCoroutine(ChangeColorCoroutine(15, Color.black, 0.5f));
        }
        else if (letra.Equals("P") || piano == 63)
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

    /*
    string getPianoKey(){
        pianoKey = "";
		if (Input.GetKeyDown (KeyCode.C) || MidiMaster.GetKeyDown (36) || MidiMaster.GetKeyDown (48) || 
			MidiMaster.GetKeyDown (60) || MidiMaster.GetKeyDown (72) || MidiMaster.GetKeyDown (84) || 
			MidiMaster.GetKeyDown (37) || MidiMaster.GetKeyDown (49) || MidiMaster.GetKeyDown (61) || 
			MidiMaster.GetKeyDown (73)) {
			return "C";
		} else if (Input.GetKeyDown (KeyCode.D) || MidiMaster.GetKeyDown (38) || MidiMaster.GetKeyDown (50) || 
			MidiMaster.GetKeyDown (62) || MidiMaster.GetKeyDown (74) || MidiMaster.GetKeyDown (39) || 
			MidiMaster.GetKeyDown (51) || MidiMaster.GetKeyDown (63) || MidiMaster.GetKeyDown (75)) {
			return 'D';

		} else if (Input.GetKeyDown (KeyCode.E) || MidiMaster.GetKeyDown (40) || MidiMaster.GetKeyDown (52) || 
			MidiMaster.GetKeyDown (64) || MidiMaster.GetKeyDown (76)) {
			return 'E';
		} else if (Input.GetKeyDown (KeyCode.F) || MidiMaster.GetKeyDown (41) || MidiMaster.GetKeyDown (53) || 
			MidiMaster.GetKeyDown (65) || MidiMaster.GetKeyDown (77) || MidiMaster.GetKeyDown (42) || 
			MidiMaster.GetKeyDown (54) || MidiMaster.GetKeyDown (66) || MidiMaster.GetKeyDown (78)) {
			return 'F';
		} else if (Input.GetKeyDown (KeyCode.G) || MidiMaster.GetKeyDown (43) || MidiMaster.GetKeyDown (55) || 
			MidiMaster.GetKeyDown (67) || MidiMaster.GetKeyDown (79) || MidiMaster.GetKeyDown (44) || 
			MidiMaster.GetKeyDown (56) || MidiMaster.GetKeyDown (68) || MidiMaster.GetKeyDown (80)) {
			return 'G';
		} else if (Input.GetKeyDown (KeyCode.A) || MidiMaster.GetKeyDown (45) || MidiMaster.GetKeyDown (57) || 
			MidiMaster.GetKeyDown (69) || MidiMaster.GetKeyDown (81) || MidiMaster.GetKeyDown (46) || 
			MidiMaster.GetKeyDown (58) || MidiMaster.GetKeyDown (70) || MidiMaster.GetKeyDown (82)) {
			return 'A';
		} else if (Input.GetKeyDown (KeyCode.B) || MidiMaster.GetKeyDown (47) || MidiMaster.GetKeyDown (59) || 
			MidiMaster.GetKeyDown (71) || MidiMaster.GetKeyDown (83)) {
			return 'B';
		} else {
			return '*';
		}
	}*/
}