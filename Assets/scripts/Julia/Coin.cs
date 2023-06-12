using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;  // Value to increase the counter by

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Increase the counter
            //Counter.instance.IncreaseCounter(coinValue);

            // Destroy the coin object
            Destroy(gameObject);
        }
    }
}
