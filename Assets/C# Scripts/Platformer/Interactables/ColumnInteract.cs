using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnInteract : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.name == "Player1")
        {
            if(collisionInfo.gameObject.GetComponent<Player1Movement>().BombPower)
            {
                Destroy(gameObject);
            }
        }

        if (collisionInfo.gameObject.name == "Player2")
        {
            if (collisionInfo.gameObject.GetComponent<Player2Movement>().BombPower)
            {
                Destroy(gameObject);
            }
        }
    }
}
