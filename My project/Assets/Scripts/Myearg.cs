using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myearg : MonoBehaviour
{
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
}
