using UnityEngine;

public class temp : MonoBehaviour
{
    public float time = 0;
    public float Timer = 0;
    public float Timer2 = 0;
    public bool isOnPlat = false;
    public GameObject Platform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Timer = time;
        Timer2 = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnPlat == true)
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {

                Platform.SetActive(false);



                Timer2 -= Time.deltaTime;
            }

        }
        if (Timer2 == 0)
        {
            Timer2 -= Time.deltaTime;
            if (Timer2 <= 0)
            {
                Platform.SetActive(true);

                Timer = time;
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        Ball pball = other.GetComponent<Ball>();
        if (pball != null)
        {

            isOnPlat = true;
        }

    }

}
