using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //every 5 seconds, spanwn enemy every 10 seconds lower spawn by 0.5 lowest can go is 1 and THEN after that, spawn ORE
    [SerializeField] GameObject dwayneBoi;
    [SerializeField] GameObject myearghBoi; 
    public GameObject[] enemiesD;
    public GameObject[] enemiesM;
    float secondsTillSpawn = 5;

    IEnumerator SpawnEnemy(){
        yield return new WaitForSeconds(1);
        Vector3 enemyPosNew = new Vector3(0, 1, 0);
        GameObject whatEnemy;
        if(Random.Range(0.0f, 10.0f) <= 2.0f){
            whatEnemy = dwayneBoi;
            if(Random.Range(0.0f, 10.0f) <= 5.0f){
                enemyPosNew = new Vector3(-12, 1, 0);
                whatEnemy.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
            }else{
                enemyPosNew = new Vector3(12, 1, 0);
            }
        }else if(Random.Range(0.0f, 10.0f) <= 4.0f){
            whatEnemy = dwayneBoi;
            if(Random.Range(0.0f, 10.0f) <= 5.0f){
                enemyPosNew = new Vector3(-12, 1, 0);
                whatEnemy.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
            }else{
                enemyPosNew = new Vector3(12, 1, 0);
            }
        }else if(Random.Range(0.0f, 10.0f) <= 6.0f){
            whatEnemy = myearghBoi;
            if(Random.Range(0.0f, 10.0f) <= 5.0f){
                enemyPosNew = new Vector3(-12, 1, 0);
            }else{
                enemyPosNew = new Vector3(12, 1, 0);
                whatEnemy.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
            }
        }else if(Random.Range(0.0f, 10.0f) <= 8.0f){
            whatEnemy = myearghBoi;
            if(Random.Range(0.0f, 10.0f) <= 5.0f){
                enemyPosNew = new Vector3(-12, 1, 0);
            }else{
                enemyPosNew = new Vector3(12, 1, 0);
                whatEnemy.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
            }
        }else{
            whatEnemy = dwayneBoi;
            if(Random.Range(0.0f, 10.0f) <= 5.0f){
                enemyPosNew = new Vector3(-12, 1, 0);
                whatEnemy.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
            }else{
                enemyPosNew = new Vector3(12, 1, 0);
            }
        }
        Instantiate(whatEnemy, enemyPosNew, Quaternion.identity);
        StartCoroutine(SpawnEnemy());
    }

    void destroyEnemy(){
        for(int i=0; i<enemiesD.Length; ++i){
            if(enemiesD[i].transform.position.x < -30 || enemiesD[i].transform.position.x > 30){
                Destroy(enemiesD[i]);
            }
        }
        for(int i=0; i<enemiesM.Length; ++i){
            if(enemiesM[i].transform.position.x < -30 || enemiesM[i].transform.position.x > 30){
                Destroy(enemiesM[i]);
            }
        }
    }

    void moveEnemyD(GameObject dwayne){
        dwayne.GetComponent<Rigidbody2D>().AddForce(transform.right);
    }

    void moveEnemyM(GameObject mmmm){
        mmmm.GetComponent<Rigidbody2D>().AddForce(transform.right*2);
    }

    void Start(){
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        enemiesD = GameObject.FindGameObjectsWithTag("EnemyDwayne");
        enemiesM = GameObject.FindGameObjectsWithTag("EnemyMyeargh");
        for(int i=1; i<enemiesD.Length; ++i){
            moveEnemyD(enemiesD[i]);
        }
        for(int i=1; i<enemiesM.Length; ++i){
            moveEnemyM(enemiesM[i]);
        }
        destroyEnemy();
    }
}
