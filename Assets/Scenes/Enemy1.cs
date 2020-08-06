using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float minSpeed;
    public float maxSpeed;

    float speed;

    player playerScript;

    public int damage;

    public GameObject explosion;

    void Start()
    {
        speed = Random.Range(minSpeed,maxSpeed);
        playerScript=GameObject.FindGameObjectWithTag("Player").GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        
        print("here");
    }

    void OnTriggerEnter2D(Collider2D hitObject)
    {
        if(hitObject.tag=="Player"){

            playerScript.TakeDamage(damage);
            Instantiate(explosion,transform.position,Quaternion.identity);
            Destroy(gameObject);

        }
    }
}
