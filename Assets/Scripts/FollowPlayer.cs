using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject cam;
    public float camhieght = 0;
    public float camDistance;

    Vector3 playerPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        getBallPosition();


        cam.transform.position = playerPosition;

    }
    public void getBallPosition()
    {
        playerPosition.x = player.transform.position.x;
        playerPosition.z = player.transform.position.z + camDistance;
        playerPosition.y = player.transform.position.y + camhieght;

    }

}
