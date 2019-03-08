using UnityEngine.UI;
using UnityEngine;

public class TruckInteract : MonoBehaviour
{
    //Conditions to check to complete level
    int TotalCoins = 1; //Edit this number on different levels
    public int CoinCount = 0;
    bool P1Present = false;
    bool P2Present = false;


    private void OnTriggerEnter2D(Collider2D TriggerObject)
    {
        if (TriggerObject.gameObject.name == "Player1")
        {
            P1Present = true;
        }

        if (TriggerObject.gameObject.name == "Player2")
        {
            P2Present = true;
        }

    }

    private void OnTriggerExit2D(Collider2D TriggerLeave)
    {
        if (TriggerLeave.gameObject.name == "Player1")
        {
            P1Present = false;
        }

        if (TriggerLeave.gameObject.name == "Player2")
        {
            P2Present = false;
        }
    }



    void Update()
    {


        if (P1Present == true && P2Present == true && CoinCount == TotalCoins)
        {
            Destroy(GameObject.Find("Player1"));
            Destroy(GameObject.Find("Player2"));
            Destroy(gameObject);

        }
    }
}
