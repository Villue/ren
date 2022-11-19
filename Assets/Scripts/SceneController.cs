using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void OpenLeaderBoard() => SceneManager.LoadScene(2);

    public void OpenGame() => SceneManager.LoadScene(1);

    public void OpenMenu() => SceneManager.LoadScene(0);

    public void CloseGame() => Application.Quit();

}
