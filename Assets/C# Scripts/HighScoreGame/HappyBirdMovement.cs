using UnityEngine;

public class HappyBirdMovement : MonoBehaviour
{
    public Sprite HappyBird;
    public Rigidbody2D rb;

    float SpawnX = 14.9f;
    float BirdSpeed = -15f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-10, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Location of spawn of new bird
        float SpawnY = Random.Range(-2.5f, 6.3f);
        
        if (transform.position.x > 15 || transform.position.x < -15)
        {
            transform.position = new Vector2(SpawnX,SpawnY);
            rb.velocity = new Vector2(BirdSpeed, 0);
            rb.angularVelocity = 0;
            transform.eulerAngles = new Vector3(0, 0, 0);
            gameObject.GetComponent<SpriteRenderer>().sprite = HappyBird;
        }
    }
}
