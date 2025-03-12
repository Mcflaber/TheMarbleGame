using UnityEngine;

public class Fall : MonoBehaviour
{
    public float time = 0;
    public float timer = 0;
    public float timer2 = 0;
    public bool isOnPlat = false;

    public GameObject platform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = time;
        timer2 = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnPlat == true)
        {
            timer--;
            if (timer <= 0)
            {
                turnOff();
                timer2--;
                if (timer2 <= 0)
                {
                    turnOn();
                }
            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        isOnPlat = true;

    }
    public void turnOff()
    {
        platform.SetActive(false);
    }
    public void turnOn()
    {
        platform.SetActive(false);
    }
    public void ResetTimer()
    {
        timer = time;
        timer2 = time;
    }
}
