using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    int howManyDeaths = 0;
    int lives = 2;
    public Camera theCam;
    public GameObject blackScreenOfCertainDeath;
    public GameObject literallyEverythingElse;
    public TextMeshPro deadText;

    void Start(){
        blackScreenOfCertainDeath.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        blackScreenOfCertainDeath.SetActive(false);
        literallyEverythingElse.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
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
        deadText.SetText = "HAHA! LOOKS LIKE YE LOSE!";
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        deadText.SetText = "What? Rigged? Barely playable? Unfair?? What are you talking about; the game was perfectly balanced.";
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        deadText.SetText = "DESIGNED TO SUCK QUARTERS OUT OF CHILDREN??";
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        deadText.SetText = "So what if it is?! We have to make money somehow-";
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        deadText.SetText = "You're going to sue us for using Dwayne \"The Rock\" Johnson's face without his consent for our rigged game...";
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        deadText.SetText = "ALRIGHT FINE!... You get 1 more try on the house.";
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        deadText.SetText = "And here; since I'm feeling generous and benevolent... HUZZAH! 2 MORE LIVES!";
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        deadText.SetText = "...INSERTED THE COIN YET? OK GOOD! GREAT, EVEN! OI'VE MODIFIED THE GAME SO EVEN *PANSIES* LIKE YOU CAN COMPLETE IT! NOW SCRAM!";
        lives = 4;
        StopCoroutine(firstDeath());
    }

    void OnCollisionEnter2D(Collision2D collision){
        
        if(collision.gameObject.tag != "Platform"){
            Debug.Log("ded");
            if(lives <= 0){
                if(howManyDeaths == 0){
                    StartCoroutine(firstDeath());
                    howManyDeaths++;
                }
            }else{
                lives -= 1;
            }
        }
    }
}
