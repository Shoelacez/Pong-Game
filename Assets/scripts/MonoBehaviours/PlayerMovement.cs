using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D myPlayer;
    private float movementX;
    private float movementY;
    public float playerSpeed=11f;
    public Transform shootingPoint;
    public GameObject bulletPrefab;

    private bool isFacingright=true;

    // Start is called before the first frame update
    void Start()
    {
        myPlayer=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();   

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }


    void Move() 
    {
        movementX=Input.GetAxisRaw("Horizontal");
        movementY=Input.GetAxisRaw("Vertical");
        transform.position+=new Vector3(movementX,movementY,0f)*playerSpeed*Time.deltaTime;
    }

    void Shoot()
    {
        Instantiate(bulletPrefab,shootingPoint.position,shootingPoint.rotation);
    }

}
