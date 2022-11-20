using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sound[] Sounds;
    // Start is called before the first frame update
    void Start()
    {
        Play("Theme");
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    void Awake()
    {
        foreach (var s in Sounds)
        {
            s.Source = gameObject.AddComponent<AudioSource>();
            s.Source.clip = s.Clip;
            s.Source.volume = s.Volume;
            s.Source.pitch = s.Pitch;
            s.Source.loop = s.Loop;
        }
    }

    public void Play(string name)
    {
        var sound = Array.Find(Sounds, x => x.Name == name);

        if(sound == null)
        { 
            Debug.LogWarning($"Sound: {name} not found");
            return;
        } 

        sound.Source.Play();
    }
}
