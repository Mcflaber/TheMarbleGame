using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    Vector3 CheckpointLocation = Vector3.zero;
    Quaternion CheckpointRotation = Quaternion.identity;
    public GameObject player;
    public GameObject cappedCheckpoint;
    public void Start()
    {
        CheckpointLocation = gameObject.transform.position;
        CheckpointRotation = gameObject.transform.rotation;
    }
    private void OnTriggerEnter(Collider other)
    {

        Instantiate(cappedCheckpoint);
        Destroy(gameObject);
    }
    public void CheckPoint()
    {
        Destroy(player);
        Instantiate(player, CheckpointLocation, CheckpointRotation);
        
    }
}
