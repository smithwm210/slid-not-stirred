using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public Sounds[] sounds;
    public static AudioManager instance;


    private void Awake() {

        if (instance == null)
            instance = this;
        else{

            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this);


        foreach(Sounds s in sounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;

          
        }
    }

    private void Start() {
        PlayLoop("Main Music");
    }


    public void Play (string name){
        Sounds s = Array.Find(sounds,sound => sound.name == name);
        s.source.Play();
    }
    public void PlayLoop (string name){
        Sounds s = Array.Find(sounds,sound => sound.name == name);
        s.source.loop = true;
        s.source.Play();
    }
    public void Stop(string name){
        Sounds s = Array.Find(sounds,sound => sound.name == name);
        s.source.Stop();
    }
}

