using UnityEngine;
using Rogue;

public class AudioManager : Singleton<AudioManager>
{
    public GameObject effectsSource;
    public GameObject uiSource;                 
    public GameObject musicSource;   
    public bool isPlaying;
    
    public void PlayEffects(AudioClip clip)
    { 
        GameObject sound = (GameObject)Instantiate(effectsSource);
        sound.transform.parent = transform;
        AudioSource soundSource = sound.GetComponent<AudioSource>();

        soundSource.clip = clip;
        soundSource.ignoreListenerPause = true;
        soundSource.Play();
    }

    public void PlayUi(AudioClip clip)
    { 
        GameObject sound = (GameObject)Instantiate(uiSource);
        sound.transform.parent = transform;
        AudioSource soundSource = sound.GetComponent<AudioSource>();

        soundSource.clip = clip;
        soundSource.ignoreListenerPause = true;
        soundSource.Play();
    }

    public void PlayMusic(AudioClip clip)
    { 
        GameObject sound = (GameObject)Instantiate(musicSource);
        sound.transform.parent = transform;
        AudioSource soundSource = sound.GetComponent<AudioSource>();

        soundSource.clip = clip;
        soundSource.Play();
        soundSource.loop = true;
        isPlaying = true;
    }

    public void PauseMusic()
    {
        AudioListener.pause = true;
    }

    public void RestoreMusic()
    {
        AudioListener.pause = false;
    }
}
