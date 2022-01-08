using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float ballSpeed=10f;
    private Rigidbody2D myBall;
    private bool hit=false;
    private float dirDeterminant=1f;
    // Start is called before the first frame update
    void Start()
    {
        myBall=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hit)
        {
            Rebound();
        }
        else
        {
            myBall.AddForce(new Vector2(dirDeterminant*ballSpeed*Time.deltaTime,0f),ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collided with"+other.gameObject);
            hit=true;
            dirDeterminant=-1*dirDeterminant;
        }
    }

    void Rebound()
    {
        myBall.AddForce(new Vector2(dirDeterminant*ballSpeed*Time.deltaTime,0f),ForceMode2D.Impulse);

    }

}
