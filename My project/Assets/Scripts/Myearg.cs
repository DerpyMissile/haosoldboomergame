using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myearg : MonoBehaviour
{
    public AudioClip[] mSounds;
    bool startingFromLeft = false;
    public bool getStartingPos(){
        return startingFromLeft;
    }
    public void setStartingPos(bool where){
        if(where){
            startingFromLeft = true;
        }else{
            startingFromLeft = false;
        }
    }

    void Start(){
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = mSounds[(int)Mathf.Floor(Random.Range(0.0f, mSounds.Length-1))];
        audio.Play();
    }
}
