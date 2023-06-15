using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 100;  // Value to increase the counter by

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Counter.instance.IncreaseCounter(coinValue);

            Destroy(gameObject);
        }
    }
}
