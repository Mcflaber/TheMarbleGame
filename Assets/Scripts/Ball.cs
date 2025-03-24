using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;

    Vector3 startingLocation = Vector3.zero;
    Quaternion startingRotation = Quaternion.identity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();



        startingLocation = gameObject.transform.position;
        startingRotation = gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Reset(float resetTime = 0)
    {   
        
        gameObject.transform.position = startingLocation;
        gameObject.transform.rotation = startingRotation;
        Debug.Log("ball reset");
    }
}
