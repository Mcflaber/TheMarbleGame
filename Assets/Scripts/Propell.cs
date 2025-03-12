using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float PropellSpeed = 0;
    public bool isOn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Ball pball = other.GetComponent<Ball>();
        if (pball != null)
        {
            propel();

        }

    }
    public void propel()
    {
        GameManager.self.ballForce = GameManager.self.ballForce * PropellSpeed;
    }
}
