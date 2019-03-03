using UnityEngine;
using UnityEngine.UI;

public class RocketMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    float SpawnX = 14.9f;
    float SpawnY = -4.1f;
    float RocketSpeed = 8f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Binary Random to determine which side rocket comes from
        float SpawnSide = Random.Range(0f, 1f);

        if (transform.position.x > 15 || transform.position.x < -15)
        {

            if (SpawnSide >= 0.5f)
            {
                transform.position = new Vector2(SpawnX, SpawnY);
                rb.velocity = new Vector2(-RocketSpeed, 0);


                //Faces rocket forward
                if (transform.rotation.eulerAngles.z != 180)
                {
                    transform.eulerAngles = new Vector3(0, 0, 180);
                }

            }
            else
            {
                transform.position = new Vector2(-SpawnX, SpawnY);
                rb.velocity = new Vector2(RocketSpeed, 0);

                //Faces rocket forward
                if (transform.rotation.eulerAngles.z == 180)
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                }
            }

        }
    }

    void OnDestroy()
    {
        //Binary Random to determine which side rocket comes from
        float SpawnSide = Random.Range(0f, 1f);

        if (transform.position.x > 15 || transform.position.x < -15)
        {

            if (SpawnSide >= 0.5f)
            {
                transform.position = new Vector2(SpawnX, SpawnY);
                rb.velocity = new Vector2(-RocketSpeed, 0);


                //Faces rocket forward
                if (transform.rotation.eulerAngles.z != 180)
                {
                    transform.eulerAngles = new Vector3(0, 0, 180);
                }

            }
            else
            {
                transform.position = new Vector2(-SpawnX, SpawnY);
                rb.velocity = new Vector2(RocketSpeed, 0);

                //Faces rocket forward
                if (transform.rotation.eulerAngles.z == 180)
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                }
            }

        }
    }
}
