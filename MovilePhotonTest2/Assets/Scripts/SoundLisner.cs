using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundLisner : MonoBehaviour {

    private new AudioSource audio;


    // Use this for initialization
    void Start () {
        audio = gameObject.GetComponent<AudioSource>();
        audio.clip = Microphone.Start(null, true, 999, 44100);
        while (Microphone.GetPosition(null) <= 0) { }
        audio.Play();

    }

    // Update is called once per frame
    void Update () {
    }
}
