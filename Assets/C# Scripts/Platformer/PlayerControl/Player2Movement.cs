using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public Rigidbody2D rb;

    //Player 2 Movement Boundaries
    float minX = -11.3f;
    float maxX = 11.3f;
    float maxY = 5.93f;

    //Player 2 Speed and Jump
    float Speed = 8f;
    float Jump = 20f;
    bool isGrounded = false;

    //Power Ups
    public bool BombPower = false;


    // Start is called before the first frame update

    private void Outofbounds()
    {

        if (transform.position.x < minX)
        {
            transform.position = new Vector2(minX, transform.position.y);
        }
        if (transform.position.x > maxX)
        {
            transform.position = new Vector2(maxX, transform.position.y);
        }
        if (transform.position.y > maxY)
        {
            transform.position = new Vector2(transform.position.x, maxY);
        }

    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal2");
        rb.velocity = new Vector2(x * Speed, rb.velocity.y);

        if (Input.GetButtonDown("Jump2") && isGrounded == true)  //&& transform.position.y != 6.3 <- possible way to fix staying on top?
        {
            rb.velocity = Vector2.up * Jump;
        }

        Outofbounds();

    }

    private void OnCollisionStay2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.name == "Ground" ||
            collisionInfo.gameObject.name == "Tiles" ||
            collisionInfo.gameObject.name == "Plank" ||
            collisionInfo.gameObject.name == "Column" ||
            collisionInfo.gameObject.name == "Player1")
        {
            isGrounded = true;
        }

    }

    private void OnCollisionExit2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.name == "Ground" ||
            collisionInfo.gameObject.name == "Tiles" ||
            collisionInfo.gameObject.name == "Plank" ||
            collisionInfo.gameObject.name == "Column" ||
            collisionInfo.gameObject.name == "Player1")
        {
            isGrounded = false;
        }

    }

}
