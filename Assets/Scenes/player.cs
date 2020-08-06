using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public Text healthDisplay;
    public GameObject loseScreen;
    Rigidbody2D rb;
    public float speed;
    Animator anim;
    AudioSource source;

    private float input;
    public int health;


    void Start()
    {
        source=GetComponent<AudioSource>();
        anim=GetComponent<Animator>();
        rb=GetComponent<Rigidbody2D>();
        healthDisplay.text = health.ToString();

    }

    private void Update(){

        if(input!=0){
            anim.SetBool("isRunning",true);
        } else{
            anim.SetBool("isRunning",false);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        input = Input.GetAxisRaw("Horizontal");
        print(input);
        rb.velocity = new Vector2(input*speed, rb.velocity.y);
    }

    public void TakeDamage(int damageAmount){

        source.Play();
        health-=damageAmount;
        healthDisplay.text = health.ToString();

        if(health<=0){
            loseScreen.SetActive(true);
            Destroy(gameObject);

        }
    }
}
