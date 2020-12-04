using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool IsGameOver { get; private set; }

    public EndPoint endPoint;

    private void Awake()
    {
        endPoint = GameObject.FindObjectOfType<EndPoint>();
    }

    private void OnEnable()
    {
        endPoint.EndPointChange.AddListener(GameOver);
    }

    private void OnDisable()
    {
        endPoint.EndPointChange.RemoveListener(GameOver);
    }

    private void GameOver()
    {
        IsGameOver = true;
        SceneManager.LoadScene("GameOver");
    }
}
