using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float BoostTime = 0;
    public float PropellSpeed = 0;
    public bool isOnBoost = false;
    public Vector3 PushDirection = Vector3.zero;
    public GameObject pad;
    public Ball ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isOnBoost)
        {
            
            BoostTime -= Time.deltaTime;
        }
        if(BoostTime <= 0)
        {
            isOnBoost = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Ball pball = other.GetComponent<Ball>();
        if (pball != null)
        {
            isOnBoost = true;
        }

    }
    public void propell(Vector3 Direction)
    {

    }
    
}
