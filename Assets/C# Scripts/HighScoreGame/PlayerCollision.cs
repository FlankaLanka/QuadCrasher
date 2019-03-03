using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    int score = 0;
    public Text Score;
    public Text HighScore;

    //Used to set Bird Animation upon hitting player
    public Sprite BirdEnemyDeathSprite;
    public Sprite EvolvedCar;


    void Start()
    {
        HighScore.text = "HighScore: " + PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    void SetCountText()
    {
        Score.text = "Score: " + score.ToString();
    }

    public GameObject explosion; //Explosion Animation for Rocket Impact


    void OnCollisionEnter2D(Collision2D CollisionInfo)
    {
        if (CollisionInfo.gameObject.name == "HappyBird")
        {
            score = score - 5;
            SetCountText();
            CollisionInfo.gameObject.GetComponent<SpriteRenderer>().sprite = BirdEnemyDeathSprite;
            
        }

    }

    void OnTriggerEnter2D (Collider2D TriggerObject)
    {
        if(TriggerObject.gameObject.name == "EndIcon")
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if (TriggerObject.gameObject.name == "Rocket")
        {
            GameObject explode = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            Destroy(TriggerObject.gameObject);
            Destroy(explode, 0.5f);
            FindObjectOfType<GameManager>().EndGame();
        }

        if (TriggerObject.gameObject.name == "Coin")
        {
            score = score + 1;
            SetCountText();

            if (score > PlayerPrefs.GetInt("HighScore", score))
            {
                PlayerPrefs.SetInt("HighScore", score);
            }
        }



        
    }

    
}
