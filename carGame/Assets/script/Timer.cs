using UnityEngine;

public class Timer : MonoBehaviour
{
    public CarScript car;

    private float boostAmount = 0f;
    private float timer = 0f;
    private bool isBoosting = false;

    public void StartBoost(float amount, float duration)
    {
        if (car == null) return;

        boostAmount = amount;
        timer = duration;
        isBoosting = true;
    }

    void Update()
    {
        if (!isBoosting || car == null) return;

        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            car.moveSpeed -= boostAmount;
            isBoosting = false;
            boostAmount = 0f;
        }
    }
}
