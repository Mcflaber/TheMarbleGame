using UnityEngine;

public class KillZ : MonoBehaviour
{
    public bool isGoal = false;
    public float resetDelay = 5;



    private void OnTriggerEnter(Collider other)
    {
        Ball Pball = other.gameObject.GetComponent<Ball>();
        if (Pball != null)
        {
            if (isGoal)
            {
                GameManager.self.GameOver();
            }
            Pball.Reset(resetDelay);
        }
    }
}
