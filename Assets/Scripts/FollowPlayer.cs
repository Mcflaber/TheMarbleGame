using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject cam;
    Vector3 playerPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = player.gameObject.transform.position;
        playerPosition.y = 10;
        cam.transform.position = playerPosition;

    }
}
