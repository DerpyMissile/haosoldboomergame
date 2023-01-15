using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //every 5 seconds, spanwn enemy every 10 seconds lower spawn by 0.5 lowest can go is 1 and THEN after that, spawn ORE
    [SerializeField] GameObject dwayneBoi;
    [SerializeField] GameObject myearghBoi; 
    [SerializeField] GameObject asterBoi;
    public GameObject[] enemiesD;
    public GameObject[] enemiesM;
    float secondsTillSpawn = 2;
    int howManySpawn = 1;

    IEnumerator SpawnEnemyCountdown(){
        yield return new WaitForSeconds(10);
        if(secondsTillSpawn == 1){
            howManySpawn++;
        }else{
            secondsTillSpawn -= 0.5f;
        }
        StartCoroutine(SpawnEnemyCountdown());
    }

    IEnumerator SpawnEnemy(){
        yield return new WaitForSeconds(secondsTillSpawn);
        Vector3 enemyPosNew = new Vector3(0, 1, 0);
        GameObject whatEnemy;
        for(int i=0; i<howManySpawn; ++i){
            int randomY = (int)Mathf.Floor(Random.Range(0.0f, 6.0f));
            if(Random.Range(0.0f, 10.0f) <= 2.0f){
                whatEnemy = dwayneBoi;
                if(Random.Range(0.0f, 10.0f) <= 5.0f){
                    enemyPosNew = new Vector3(-12, randomY, 0);
                    whatEnemy.GetComponent<Dwayne>().setStartingPos(false);
                }else{
                    enemyPosNew = new Vector3(12, randomY, 0);
                    whatEnemy.GetComponent<Dwayne>().setStartingPos(true);
                }
            }else if(Random.Range(0.0f, 10.0f) <= 4.0f){
                whatEnemy = asterBoi;
                enemyPosNew = new Vector3(randomY-2, 10, 0);
            }else if(Random.Range(0.0f, 10.0f) <= 6.0f){
                whatEnemy = myearghBoi;
                if(Random.Range(0.0f, 10.0f) <= 5.0f){
                    enemyPosNew = new Vector3(-12, randomY, 0);
                    whatEnemy.GetComponent<Myearg>().setStartingPos(false);
                }else{
                    enemyPosNew = new Vector3(12, randomY, 0);
                    whatEnemy.GetComponent<Myearg>().setStartingPos(true);
                }
            }else if(Random.Range(0.0f, 10.0f) <= 8.0f){
                whatEnemy = myearghBoi;
                if(Random.Range(0.0f, 10.0f) <= 5.0f){
                    enemyPosNew = new Vector3(-12, randomY, 0);
                    whatEnemy.GetComponent<Myearg>().setStartingPos(false);
                }else{
                    enemyPosNew = new Vector3(12, randomY, 0);
                    whatEnemy.GetComponent<Myearg>().setStartingPos(true);
                }
            }else{
                whatEnemy = dwayneBoi;
                if(Random.Range(0.0f, 10.0f) <= 5.0f){
                    enemyPosNew = new Vector3(-12, randomY, 0);
                    whatEnemy.GetComponent<Dwayne>().setStartingPos(false);
                }else{
                    enemyPosNew = new Vector3(12, randomY, 0);
                    whatEnemy.GetComponent<Dwayne>().setStartingPos(true);
                }
            }
            Instantiate(whatEnemy, enemyPosNew, Quaternion.identity);
        }
        if(PlayerStats.nextLevel){
            yield return new WaitUntil(() => !PlayerStats.nextLevel);
            howManySpawn = 1;
            secondsTillSpawn = 2;
        }
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

    void moveEnemyD(ref GameObject dwayne){
        if(dwayne.GetComponent<Dwayne>().getStartingPos()){
            dwayne.GetComponent<Rigidbody2D>().AddForce(transform.right);
        }else{
            dwayne.GetComponent<Rigidbody2D>().AddForce(-transform.right);
        }
    }

    void moveEnemyM(GameObject mmmm){
        if(mmmm.GetComponent<Myearg>().getStartingPos() == false){
            mmmm.GetComponent<Rigidbody2D>().AddForce(transform.right*2);
        }else{
            mmmm.GetComponent<Rigidbody2D>().AddForce(transform.right*-2);
        }
    }

    void Start(){
        StartCoroutine(SpawnEnemy());
        StartCoroutine(SpawnEnemyCountdown());
    }

    // Update is called once per frame
    void Update()
    {
        enemiesD = GameObject.FindGameObjectsWithTag("EnemyDwayne");
        enemiesM = GameObject.FindGameObjectsWithTag("EnemyMyeargh");
        for(int i=1; i<enemiesD.Length; ++i){
            moveEnemyD(ref enemiesD[i]);
        }
        for(int i=1; i<enemiesM.Length; ++i){
            moveEnemyM(enemiesM[i]);
        }
        destroyEnemy();
    }
}
