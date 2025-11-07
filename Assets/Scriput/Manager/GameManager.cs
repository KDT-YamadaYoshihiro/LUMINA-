using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public enum GameState { Tutorial, Battle, Result }
    public GameState state;

    void Start()
    {
        state = GameState.Tutorial;
    }

    public void StartBattle()
    {
        state = GameState.Battle;
        SceneManager.LoadScene("BossBattle");
    }
}
