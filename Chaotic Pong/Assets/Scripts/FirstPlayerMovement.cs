using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPlayerMovement : MonoBehaviour
{
    public float movement_speed;

    private void FixedUpdate()
    {
        //Get vertical axis input
        float y_input = Input.GetAxis("Vertical");

        transform.position = new Vector2(transform.position.x, transform.position.y + y_input * movement_speed);
    }

    //Update is called once per frame
    void Update()
    {
        
    }
}
