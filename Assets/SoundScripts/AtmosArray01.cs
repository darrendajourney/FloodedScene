using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AtmosArray01 : MonoBehaviour
{
    public AudioClip[] audioclip;
    public AudioSource audioSource;
    public AudioMixer mixer;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void AtmosArray()
    {
        audioSource.clip = audioclip[(int)Random.Range(0, audioclip.Length -1)]; 
        mixer.SetFloat("MixerVolume", -10);
        audioSource.Play(); 
    }

}