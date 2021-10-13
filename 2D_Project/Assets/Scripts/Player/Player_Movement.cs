using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float movement_speed;
    public float jump_force;
    public Rigidbody2D rig;

    //FixedUpdate called every ~0.2 seconds
    void FixedUpdate()
    {
        float x_input = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(movement_speed * x_input, rig.velocity.y);

        //Flip sprite if going left
        if(x_input != 0)
        {
            GetComponentInChildren<SpriteRenderer>().flipX = x_input < 0;
        }
    }
    
    //Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && IsGrounded())
        {
            rig.AddForce(Vector2.up * jump_force, ForceMode2D.Impulse);
        }
    }

    bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position - new Vector3(0, 0.68f, 0), Vector2.down, 0.01f);
     
        return hit.collider != null;
    }
}
