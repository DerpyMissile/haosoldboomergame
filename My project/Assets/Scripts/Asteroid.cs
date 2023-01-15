using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public AudioClip[] asterSounds;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite; 
    }

    IEnumerator hi(){
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Platform" && collision.gameObject.tag != "Player"){
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), this.GetComponent<Collider2D>());
        }
        if(collision.gameObject.tag == "Platform"){
            ChangeSprite();
            StartCoroutine(hi());
        }
    }

    void Start(){
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = asterSounds[(int)Mathf.Floor(Random.Range(0.0f, asterSounds.Length-1))];
        audio.Play();
    }
}
