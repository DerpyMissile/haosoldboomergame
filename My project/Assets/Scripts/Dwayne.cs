using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dwayne : MonoBehaviour
{
    bool startingFromLeft;
    public bool getStartingPos(){
        return startingFromLeft;
    }
    public void setStartingPos(bool where){
        startingFromLeft = where;
    }
}
