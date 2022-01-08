using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    private float movementAlongY;
    public float playerSpeed=11f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        movementAlongY=Input.GetAxisRaw("Vertical");
        transform.position+=new Vector3(0f,movementAlongY,0f)*playerSpeed*Time.deltaTime;
    }
    
}
