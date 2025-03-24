using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float PropellSpeed = 0;
    public bool isOn;
    Ball player;
    public Vector3 direction = Vector3.zero;

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
        GameManager.self.Pushball(direction);
   

    }
    public void propel()
    {

    }
}
