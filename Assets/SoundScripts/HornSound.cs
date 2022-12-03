using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HornSound : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Invoke("horn", 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void horn()
    {
        audioSource.clip = clips[(clips.Length -1)]; 
        audioSource.Play(); 
        Invoke("horn", 20.0f);
    }
}
