using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Ball ball;
    public Text playerScoreText;
    public Text computerScoreText;
    public Paddle playerPadlle;
    public Paddle computerPadlle;

    private int _playerScore;

    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();

        ResetRound();
    }

    public void ComputerScores()
    {
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();

        ResetRound();
    }

    private void ResetRound()
    {
        this.playerPadlle.ResetPosition();
        this.computerPadlle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    
}
