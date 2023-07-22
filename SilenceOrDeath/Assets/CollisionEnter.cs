using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnter : MonoBehaviour
{
   public AudioSource audioSource;
    void Start(){
    }
	public void OnCollisionEnter(Collision collision)
    {

        if(audioSource != null && !audioSource.isPlaying){
            audioSource.Play();
        }
       
    }

    public void AudioStart()
    {

        if(audioSource != null && !audioSource.isPlaying){
            audioSource.Play();
        }
       
    }
}
