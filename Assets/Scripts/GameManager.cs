using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    int score = 0;
    public GameObject WinText;
    public GameObject RestartButton;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ScoreUp()
    {
        score++;
        if (score >= 5)
        {
            Win();
        }
    }

    private void Win()
    {
        WinText.SetActive(true);
        RestartButton.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
