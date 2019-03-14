using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    public Rigidbody2D rb;

    //Player 1 Movement Boundaries
    float minX = -11.784f;
    float maxX = 11.784f;
    float maxY = 6.408f;

    //Player 1 Speed and Jump
    float Speed = 10f;
    float Jump = 20f;
    bool isGrounded = false;
    float SpringJumpBoost = 1.33f;

    //Power Ups
    public bool BombPower = false;
    public bool SpringPower = false;

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
        float x = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(x * Speed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            rb.velocity = Vector2.up * Jump;
        }

        Outofbounds();
        SpringPowerCheck();



    }

    private void OnCollisionStay2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.name == "Ground" ||
            collisionInfo.gameObject.name == "Tiles" ||
            collisionInfo.gameObject.name == "Plank" ||
            collisionInfo.gameObject.name == "Column" ||
            collisionInfo.gameObject.name == "Player2")
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
            collisionInfo.gameObject.name == "Player2")
        {
            isGrounded = false;
        }

    }

    private void SpringPowerCheck()
    {
        if (SpringPower)
        {
            Jump = Jump * SpringJumpBoost;
            SpringPower = false;
        }
    }

}
