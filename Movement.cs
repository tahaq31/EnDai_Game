using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    public float movespeed= 5f;
    public Rigidbody2D rb;
    Vector2 playerMovement;

    public Sprite forwardMovement1;
    public Sprite forwardMovement2;
    public Sprite forwardMovement3;

    public Sprite backMovement1;
    public Sprite backMovement2;
    public Sprite backMovement3;

    public Sprite rightMovement1;
    public Sprite rightMovement2;
    public Sprite rightMovement3;

    public Sprite leftMovement1;
    public Sprite leftMovement2;
    public Sprite leftMovement3;

    public int Framecounter = 0;


    // Update is called once per frame
    void Update()
    {
        //input

        playerMovement.x = Input.GetAxisRaw("Horizontal");
        playerMovement.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        if (Framecounter == 15)
        {
            Framecounter = 0;
        }
        //movement
        if (Input.GetKey(KeyCode.D))
        {
            rightWalk();
        }
        if (Input.GetKey(KeyCode.A))
        {
            leftWalk();
        }
        if (Input.GetKey(KeyCode.W))
        {
            forwardWalk();
        }
        if (Input.GetKey(KeyCode.S))
        {
            backWalk();
        }
        rb.MovePosition(rb.position + playerMovement * movespeed*Time.fixedDeltaTime);
        Framecounter++;
    }
    public void forwardWalk()
    {
        if (Framecounter == 0) { this.gameObject.GetComponent<SpriteRenderer>().sprite = forwardMovement1; }
        if (Framecounter == 5) { this.gameObject.GetComponent<SpriteRenderer>().sprite = forwardMovement2; }
        if (Framecounter == 10) { this.gameObject.GetComponent<SpriteRenderer>().sprite = forwardMovement3; }
    }
    public void backWalk()
    {
        if (Framecounter == 0) { this.gameObject.GetComponent<SpriteRenderer>().sprite = backMovement1; }
        if (Framecounter == 5) { this.gameObject.GetComponent<SpriteRenderer>().sprite = backMovement2; }
        if (Framecounter == 10) { this.gameObject.GetComponent<SpriteRenderer>().sprite = backMovement3; }
    }
    public void leftWalk()
    {
        if (Framecounter == 0) { this.gameObject.GetComponent<SpriteRenderer>().sprite = leftMovement1; }
        if (Framecounter == 5) { this.gameObject.GetComponent<SpriteRenderer>().sprite = leftMovement2; }
        if (Framecounter == 10) { this.gameObject.GetComponent<SpriteRenderer>().sprite = leftMovement3; }
    }
    public void rightWalk()
    {
        if (Framecounter == 0) { this.gameObject.GetComponent<SpriteRenderer>().sprite = rightMovement1; }
        if (Framecounter == 5) { this.gameObject.GetComponent<SpriteRenderer>().sprite = rightMovement2; }
        if (Framecounter == 10) { this.gameObject.GetComponent<SpriteRenderer>().sprite = rightMovement3; }
    }

    public float playerPosition()
    {

        

        return 0;
    }

}
