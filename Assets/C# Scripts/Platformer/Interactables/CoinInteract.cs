using UnityEngine;

public class CoinInteract : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D TriggerObject)
    {
        if (TriggerObject.gameObject.name == "Player1" || TriggerObject.gameObject.name == "Player2")
        {
            Destroy(gameObject);
            GameObject.Find("Truck").GetComponent<TruckInteract>().CoinCount 
                = GameObject.Find("Truck").GetComponent<TruckInteract>().CoinCount + 1;
        }
    }

}
