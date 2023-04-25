
using UnityEngine;
//using NAudio.Midi;

public class MIDI : MonoBehaviour
{
   /* private MidiIn midiIn;

    void Start()
    {
        // Abre el primer dispositivo MIDI disponible
        midiIn = new MidiIn(0);

        // Suscribirse al evento de recepción de mensajes MIDI
        midiIn.MessageReceived += OnMidiEvent;

        // Inicia la recepción de mensajes MIDI
        midiIn.Start();
    }

    void OnMidiEvent(object sender, MidiInMessageEventArgs e)
    {
        // Si el mensaje es una nota, imprimir su valor
        if (e.MidiEvent.CommandCode == MidiCommandCode.NoteOn)
        {
            Debug.Log("Nota MIDI detectada: " + e.MidiEvent.NoteNumber);
        }
    }

    void OnDestroy()
    {
        // Detiene la recepción de mensajes MIDI y libera los recursos
        if (midiIn != null)
        {
            midiIn.Stop();
            midiIn.Dispose();
        }
    }*/
}