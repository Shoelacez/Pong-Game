using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3 : MonoBehaviour
{
    private float speed=10f;
    private Rigidbody2D myPlayer;

    Vector2 movement=new Vector2();
    private float hitPoints=3f;

    // Start is called before the first frame update
    void Start()
    {
        myPlayer=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }
     
     void Move()
     {
        movement.x=Input.GetAxisRaw("Horizontal");
        movement.y=Input.GetAxisRaw("Vertical");
        movement.Normalize();
        myPlayer.velocity=movement*speed;
     }

     private void OnTriggerEnter2D(Collider2D other) 
     {
        if (other.gameObject.CompareTag("CanBePickedUp"))
        {
            // Debug.Log(other.gameObject+" picked up by "+this.gameObject);
            Item hitObject= other.gameObject.GetComponent<Consumables>().item;

            if (hitObject != null)
            {
                print("hit: "+hitObject.objectName);

                switch (hitObject.itemType)
                {
                    case Item.ItemType.COIN:
                        break;

                    case Item.ItemType.HEALTH:
                        AdjustPoints(hitObject.quantity);
                        break;
                    default:
                    break;
                }

                other.gameObject.SetActive(false);

            }
        }    
     }

     public void AdjustPoints(int amount)
     {
         hitPoints+=amount;
         print("Adjusted Points by: "+amount+".New Value: "+hitPoints);
     }
}
