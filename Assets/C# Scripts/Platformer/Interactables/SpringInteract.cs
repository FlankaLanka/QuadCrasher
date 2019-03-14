using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringInteract : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D TriggerObject)
    {
        if(TriggerObject.gameObject.name == "Player1")
        {
            P1SpringPowerUp(TriggerObject);
        }
        if (TriggerObject.gameObject.name == "Player2")
        {
            P2SpringPowerUp(TriggerObject);
        }
    }

    public void P1SpringPowerUp(Collider2D Player)
    {
        Player.GetComponent<Player1Movement>().SpringPower = true;
        Destroy(gameObject);
    }

    public void P2SpringPowerUp(Collider2D Player)
    {
        Player.GetComponent<Player2Movement>().SpringPower = true;
        Destroy(gameObject);
    }

}
