using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankInteract : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.name == "Player2")
        {
            Destroy(gameObject);
        }
    }
}
