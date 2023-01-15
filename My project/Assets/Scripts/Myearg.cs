using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myearg : MonoBehaviour
{
    bool startingFromLeft = false;
    // private Animator animate;
    // private SpriteRenderer sprite;

    // private enum state { run }

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

    // private void Start(){
    //     animate = GetComponent<Animator>();
    //     sprite = GetComponent<SpriteRenderer>();
    // }

    // private void Update(){
    //     AnimationUpdate();
    // }

    // private void AnimationUpdate(){
    //     state currState;
    //     currState = state.run;
    //     animate.SetInteger("currState", (int)currState);
    // }
}
