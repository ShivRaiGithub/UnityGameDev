using UnityEngine;

public class Booster : MonoBehaviour
{
    [Header("Assigned via Inspector")]
    public CarScript carScript;    
    public Timer timerScript;

    public float boostAmount = 50f;
    public float boostDuration = 5f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Car"))
        {
            if (carScript != null)
            {
                carScript.moveSpeed += boostAmount;

                if (timerScript != null)
                {
                    timerScript.StartBoost(boostAmount, boostDuration);
                }

                Destroy(gameObject);
            }
        }
    }
}
