using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject[] enemiesD;
    public GameObject[] enemiesM;

    void moveEnemyD(GameObject dwayne){
        dwayne.GetComponent<Rigidbody2D>().AddForce(transform.right);
    }

    void moveEnemyM(){

    }

    // Update is called once per frame
    void Update()
    {
        enemiesD = GameObject.FindGameObjectsWithTag("EnemyDwayne");
        enemiesM = GameObject.FindGameObjectsWithTag("EnemyMyeargh");
        for(int i=0; i<enemiesD.Length; ++i){
            moveEnemyD(enemiesD[i]);
        }
    }
}
