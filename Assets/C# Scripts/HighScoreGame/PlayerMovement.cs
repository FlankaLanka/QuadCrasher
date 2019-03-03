using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    //Player Movement Boundaries
    float minX = -11.6f;
    float maxX = 11.6f;
    float maxY = 6.3f;

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
        float x = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(x * 10, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))  //&& transform.position.y != 6.3 <- possible way to fix staying on top?
        {
            rb.velocity = Vector2.up * 20;
        }

        Outofbounds();

    }

}
