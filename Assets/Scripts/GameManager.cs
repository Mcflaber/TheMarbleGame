using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager self;
    public Ball ball;
    public Vector3 accelerationData = Vector3.zero;
    public TextMeshProUGUI AccelDataField;
    public TextMeshProUGUI VelDataField;
    public TextMeshProUGUI ScoreField;
    public TextMeshProUGUI FinalScoreField;
    public float ballForce = 10;
    public float gravity = 5;
    public float Score = 0;
    Accelerometer accel;
    public GameObject gameOverScreen;
    public Vector3 velocity = Vector3.zero;
    
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

        velocity = ball.rb.linearVelocity;

        VelDataField.text = velocity.ToString();

        Vector3 direction = Vector3.zero;
        direction.x = accelerationData.x * ballForce;
        direction.y = velocity.y;
        direction.z = accelerationData.y * ballForce;
        
        Pushball(direction);


    }
    public void Pushball(Vector3 direction)
    {

        ball.rb.linearVelocity = direction;
    }
    public void gravityForce()
    {
        //ball.rb.linearVelocity = velocity.y;
    }

    public void StartGame()
    {
        gameOverScreen.SetActive(false);
        SceneManager.LoadScene("MarbleGame");
    }
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void AddScore(float points)
    {
        Score += points;
        ScoreField.text = Score.ToString();
        FinalScoreField.text = Score.ToString();
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }
}
