using UnityEngine;

public class Point : MonoBehaviour
{
    public float points = 10;
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
        GameManager.addScore(points);
        Destroy(gameObject);
    }
}
