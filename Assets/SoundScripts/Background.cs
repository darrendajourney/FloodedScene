using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Invoke("background", 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void background()
    {
        audioSource.pitch = Random.Range(0.5f, 0.8f);
        audioSource.Play(); 
        Invoke("background", 35f);
    }

}
