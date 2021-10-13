using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Rotate : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        ContactPoint2D contact = collision.contacts[0];
        float angle = Mathf.Atan2(contact.normal.y, contact.normal.x);
        angle *= Mathf.Rad2Deg;
        angle -= 90.0f;

        transform.localRotation = new Quaternion();
        Camera.main.transform.localRotation = new Quaternion();

        if(angle < -80 || angle > 80)
        {
            return;
        }

        transform.Rotate(Vector3.forward * angle);

        Camera.main.transform.Rotate(Vector3.forward * -angle);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        //Reset Rotation
        transform.localRotation = new Quaternion();
        Camera.main.transform.localRotation = new Quaternion();
    }
}
