using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float PropellSpeed = 0;
    public bool isOn;
    Ball player;
    Vector3 Pdirection = Vector3.zero;
    public float x = 0;
    public float y = 0;
    public float z = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Pdirection.x = x * PropellSpeed;
        Pdirection.y = y * PropellSpeed;
        Pdirection.z = z * PropellSpeed;
    }
    private void OnTriggerEnter(Collider other)
    {
        GameManager.self.Pushball(Pdirection);
   

    }
    public void propel()
    {

    }
}
