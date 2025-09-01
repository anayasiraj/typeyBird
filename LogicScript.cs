using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText; 
    public GameObject gameOverScreen;
    public AudioSource ding;
    public AudioSource aww;
    // public GameObject bird;


    [ContextMenu("Increase Score")]    // power to run the function from unity
    public void addScore(int scoreToAdd)
    {
        /* if (bird.birdIsAlive) {
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
        }*/
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        ding.Play();

    }


    // can make seperate script tho but for restarting game button
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        aww.Play();

    }
    
    public void backToTitle()
    {
        SceneManager.LoadScene("TitleScene", LoadSceneMode.Single); // wanna restrat to current scene
    }



}
