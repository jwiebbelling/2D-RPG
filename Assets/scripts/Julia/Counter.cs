using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text counterText;
    private int counter = 0;

    public static Counter instance;

    private void Awake()
    {
        // Ensure only one instance of the Counter exists
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void IncreaseCounter(int value)
    {
        counter += value;
        UpdateCounterText();
    }

    private void UpdateCounterText()
    {
        counterText.text = counter.ToString();
    }
}
