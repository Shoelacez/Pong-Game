using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float BulletSpeed=10f;
    private Rigidbody2D myBullet;


    // Start is called before the first frame update
    void Start()
    {
        myBullet=GetComponent<Rigidbody2D>();

        myBullet.velocity=new Vector2(BulletSpeed,myBullet.velocity.y);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag=="enemy" || other.gameObject.tag=="wall")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }    
    }

}
