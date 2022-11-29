using UnityEngine;
using UnityEngine.Audio;
using System;

[System.Serializable]
public class Sound
{
    public string Name;
    public AudioClip Clip;
    [Range(0f, 1f)]
    public float Volume;
    [Range(0f, 1f)]
    public float Pitch;
    [HideInInspector]
    public AudioSource Source;
    public bool Loop;

}
