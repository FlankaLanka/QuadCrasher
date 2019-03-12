using UnityEngine;

public class BombInteract : MonoBehaviour
{
    public bool P1BombAcquired = false;
    public bool P2BombAcquired = false;

    private void OnTriggerEnter2D(Collider2D TriggerObject)
    {
        if (TriggerObject.gameObject.name == "Player1")
        {
            P1BombPowerUp(TriggerObject);
        }

        if(TriggerObject.gameObject.name == "Player2")
        {
            P2BombPowerUp(TriggerObject);
        }


    }

    private void P1BombPowerUp(Collider2D Player)
    {
        Player.GetComponent<Player1Movement>().BombPower = true;
        Destroy(gameObject);
    }

    private void P2BombPowerUp(Collider2D Player)
    {
        Player.GetComponent<Player2Movement>().BombPower = true;
        Destroy(gameObject);
    }

}
