using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerDeath : MonoBehaviour
{
    //heart 1 is (-9, 4.665315)
    //heart 2 is (-8.25, --)
    //heart 3 is (-7.5, --)
    //heart 4 is (-6.75, --)
    //heart 5 is (-6, --)
    //heart 6 is (-5.25, --)
    //heart 7 is (-4.5, --)
    public Camera theCam;

    public GameObject thePlayer;
    public GameObject blackScreenOfCertainDeath;
    public GameObject literallyEverythingElse;
    public TextMeshProUGUI deadText;
    public GameObject[] hearts;
    public GameObject stage2heart1;
    public GameObject stage2heart2;
    public GameObject stage3heart1;
    public GameObject stage3heart2;
    public GameObject stage1;
    public GameObject stage2;
    public GameObject stage3;

    void Start(){
        blackScreenOfCertainDeath.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        blackScreenOfCertainDeath.SetActive(false);
        literallyEverythingElse.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        stage2heart1.SetActive(false);
        stage2heart2.SetActive(false);
        stage3heart1.SetActive(false);
        stage3heart2.SetActive(false);
        stage2.SetActive(false);
        hearts = GameObject.FindGameObjectsWithTag("Heart");
    }

    IEnumerator firstDeath(){
        yield return new WaitForSeconds(1);
        while(theCam.orthographicSize <= 50){
            theCam.orthographicSize+=4;
            yield return new WaitForSeconds(1);
        }
        blackScreenOfCertainDeath.SetActive(true);
        blackScreenOfCertainDeath.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.6f);
        literallyEverythingElse.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
        yield return new WaitForSeconds(1);
        blackScreenOfCertainDeath.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
        literallyEverythingElse.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.6f);
        yield return new WaitForSeconds(1);
        blackScreenOfCertainDeath.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.6f);
        literallyEverythingElse.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
        yield return new WaitForSeconds(1);
        blackScreenOfCertainDeath.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
        literallyEverythingElse.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.6f);
        yield return new WaitForSeconds(1);
        blackScreenOfCertainDeath.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.7f);
        literallyEverythingElse.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.2f);
        deadText.SetText("HAHA! LOOKS LIKE YE LOSE!");
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        yield return new WaitForSeconds(1);
        deadText.SetText("What? Rigged? Barely playable? Unfair?? What are you talking about; the game was perfectly balanced.");
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        deadText.SetText("DESIGNED TO SUCK QUARTERS OUT OF CHILDREN??");
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        deadText.SetText("So what if it is?! We have to make money somehow-");
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        deadText.SetText("You're going to sue us for using Dwayne \"The Rock\" Johnson's face without his consent for our rigged game...");
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        deadText.SetText(".............");
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        deadText.SetText("ALRIGHT FINE!... You get 1 more try on the house.");
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        deadText.SetText("And here; since I'm feeling generous and benevolent... HUZZAH! 2 MORE LIVES!");
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        deadText.SetText("...INSERTED THE COIN YET? OK GOOD! GREAT, EVEN! OI'VE MODIFIED THE GAME SO EVEN *PANSIES* LIKE YOU CAN COMPLETE IT! NOW SCRAM!");
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        PlayerStats.nextLevel = true;
        PlayerStats.lives = 4;
        while(theCam.orthographicSize > 5){
            theCam.orthographicSize-=4;
            yield return new WaitForSeconds(1);
        }
        stage1.SetActive(false);
        stage2.SetActive(true);
        PlayerStats.nextLevel = false;
        StopCoroutine(firstDeath());
        prepareSecondStage();
    }

    IEnumerator secondDeath(){
        yield return new WaitForSeconds(1);
        while(theCam.orthographicSize <= 50){
            theCam.orthographicSize+=4;
            yield return new WaitForSeconds(1);
        }
        blackScreenOfCertainDeath.SetActive(true);
        blackScreenOfCertainDeath.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.6f);
        literallyEverythingElse.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
        yield return new WaitForSeconds(1);
        blackScreenOfCertainDeath.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
        literallyEverythingElse.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.6f);
        yield return new WaitForSeconds(1);
        blackScreenOfCertainDeath.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.6f);
        literallyEverythingElse.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
        yield return new WaitForSeconds(1);
        blackScreenOfCertainDeath.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
        literallyEverythingElse.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.6f);
        yield return new WaitForSeconds(1);
        blackScreenOfCertainDeath.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.7f);
        literallyEverythingElse.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.2f);
        deadText.SetText("lmao loser");
        Application.Quit();
    }

    void prepareSecondStage(){
        stage2heart1.SetActive(true);
        stage2heart2.SetActive(true);
        Destroy(hearts[0].GetComponent<Rigidbody2D>());
        Destroy(hearts[1].GetComponent<Rigidbody2D>());
        Destroy(hearts[2].GetComponent<Rigidbody2D>());
        hearts[0].transform.position = new Vector3(-9.0f, 4.665315f, 0);
        hearts[1].transform.position = new Vector3(-8.25f, 4.665315f, 0);
        hearts[2].transform.position = new Vector3(-7.5f, 4.665315f, 0);
        thePlayer.transform.position = new Vector3(0, 5.0f, 10f);
        blackScreenOfCertainDeath.SetActive(false);
        PlayerStats.dieded = false;
    }

    void OnCollisionEnter2D(Collision2D collision){
        
        if(collision.gameObject.tag != "Platform"){
            hearts = GameObject.FindGameObjectsWithTag("Heart");
            Debug.Log("ded");
            hearts[PlayerStats.lives].AddComponent<Rigidbody2D>();
            if(PlayerStats.lives <= 0 && !PlayerStats.dieded){
                PlayerStats.dieded = true;
                if(PlayerStats.howManyDeaths == 0){
                    StartCoroutine(firstDeath());
                    PlayerStats.howManyDeaths++;
                }else if(PlayerStats.howManyDeaths == 1){
                    StartCoroutine(secondDeath());
                    PlayerStats.howManyDeaths++;
                }
            }else{
                PlayerStats.lives -= 1;
            }
        }
    }
}
