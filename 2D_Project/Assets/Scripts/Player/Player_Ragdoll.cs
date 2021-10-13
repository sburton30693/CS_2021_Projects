using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Ragdoll : MonoBehaviour
{
    public Collider2D other_collider;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider == other_collider)
        {
            //Toggle Freeze Rotation
            GetComponent<Rigidbody2D>().freezeRotation = !GetComponent<Rigidbody2D>().freezeRotation;

            if(GetComponent<Rigidbody2D>().freezeRotation)
            {
                //Reset rotation
                transform.localRotation = new Quaternion();
            }
        }
    }
}
