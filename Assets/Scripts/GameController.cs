using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    [SerializeField] private GameObject UserNameInput;

    [SerializeField] private UserData userData;

    public static int Points { get; private set; }

    public static bool GameStarted { get; private set; }

    [SerializeField]
    private TextMeshProUGUI gameResult;
    [SerializeField]
    private TextMeshProUGUI pointsText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        gameResult.text = "";

        SetPoints(0);
        GameStarted = true;

        Field.Instance.GenerateField();
    }

    public void Win()
    {
        GameStarted = false;
        UserNameInput.SetActive(true);
    }

    public void Lose()
    {
        GameStarted = false;
        UserNameInput.SetActive(true);
    }

    public void AddUserLeaderBoard(string str)
    {
        SceneManager.LoadScene(0);
        userData.
    }

    public void AddPoints(int points)
    {
        SetPoints(Points + points);
    }

    private void SetPoints(int points)
    {
        Points = points;
        pointsText.text = Points.ToString();
    }
}
