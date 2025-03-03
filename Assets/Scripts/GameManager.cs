using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static MazeManager self;
    public MazeBall ball;
    public Vector3 accelerationData = Vector3.zero;
    public TextMeshProUGUI AccelDataField;
    public float ballForce = 10;
    Accelerometer accel;
    public GameObject gameOverScreen;
    bool northButton = false;
    protected void OnEnable()
    {
        // All sensors start out disabled so they have to manually be enabled first.
        InputSystem.EnableDevice(Accelerometer.current);
    }

    protected void OnDisable()
    {
        InputSystem.DisableDevice(Accelerometer.current);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        //lazy singletone
        self = this;

    }

    // Update is called once per frame
    void Update()
    {
        accel = Accelerometer.current;
        if (accel != null)
        {
            accelerationData = Accelerometer.current.acceleration.ReadValue();

        }
        AccelDataField.text = accelerationData.ToString();

        Vector3 direction = Vector3.zero;
        direction.x = accelerationData.x;
        direction.y = 0;
        direction.z = accelerationData.y;

        Pushball(direction);



    }
    public void Pushball(Vector3 direction)
    {

        ball.rb.linearVelocity = direction * ballForce;
    }
    public void StartGame()
    {
        gameOverScreen.SetActive(false);
        SceneManager.LoadScene("Maze");
    }
    public void EndGame()
    {
        gameOverScreen.SetActive(true);
    }
}
