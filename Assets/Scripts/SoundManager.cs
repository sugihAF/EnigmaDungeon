using UnityEngine.Audio;
using UnityEngine;
using System;
public class SoundManager : MonoBehaviour
{
    public Sound[] sounds;
    public static SoundManager instance;
    private void Awake()
    {
        if(instance == null){
            instance = this;
        }else{
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        foreach(Sound s in sounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = 1f;
            s.source.loop = s.loop;
        }
    }
    void Start()
    {
        PlaySound("theme");
    }
    // Update is called once per frame
    public void PlaySound(string clip){
        
        Sound s = Array.Find(sounds, Sound => Sound.name == clip);
        s.source.Play();
    }
}
