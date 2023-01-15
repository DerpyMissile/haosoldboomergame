using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dwayne : MonoBehaviour
{
    public AudioClip[] rockSounds;
    bool startingFromLeft;
    public bool getStartingPos(){
        return startingFromLeft;
    }
    public void setStartingPos(bool where){
        startingFromLeft = where;
    }
    void Start(){
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = rockSounds[(int)Mathf.Floor(Random.Range(0.0f, rockSounds.Length-1))];
        audio.Play();
    }
}
