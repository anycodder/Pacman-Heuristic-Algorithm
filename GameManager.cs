using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    //public static GameManager Instance { get; private set; }
    //public Pacman pacman;
    public TextMeshProUGUI ScoreText;
    public int Score=0;
    private void Start()
    {

    }
    public void updateScore()
    {
        Score++;
        if (ScoreText != null)
        {
            ScoreText.text = "Score: " + Score.ToString();
        }
    }
}