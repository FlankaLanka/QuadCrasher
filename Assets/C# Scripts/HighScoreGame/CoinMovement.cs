using UnityEngine;
using UnityEngine.UI;

public class CoinMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    //Coin appearance boundaries
    float minX = -11.5f;
    float maxX = 11.5f;
    float minY = 6.2f;
    float maxY = -4.4f;

    float SpawnX;
    float SpawnY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        SpawnX = Random.Range(minX, maxX);
        SpawnY = Random.Range(minY, maxY);
    }

    //Moves coin when player collects it
    void OnTriggerEnter2D(Collider2D TriggerObject)
    {
        if (TriggerObject.gameObject.name == "Player")
        {
            rb.transform.position = new Vector2(SpawnX,SpawnY);

        }
    }
}
