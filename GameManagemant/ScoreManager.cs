using System.Collections; // import System.Collections namespace
using UnityEngine; // import UnityEngine namespace
using UnityEngine.UI; // import UnityEngine.UI namespace

public class ScoreManager : MonoBehaviour
{
    public static int score; // declare a static public integer variable "score"
    public Text highScore; // declare a public Text object "highScore"

    Text text; // declare a private Text object "text"

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString(); // set the "highScore" Text object's text to the value of the "HighScore" key stored in PlayerPrefs, which defaults to 0 if the key does not exist
    }

    void Awake()
    {
        text = GetComponent<Text>(); // get the Text component attached to the same GameObject as the script and store it in the "text" variable
        score = 0; // set the "score" variable to 0
    }

    void Update()
    {
        text.text = "" + score; // set the "text" Text object's text to the value of the "score" variable

        // update the high score if the current score is higher than the stored high score
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score); // update the "HighScore" PlayerPrefs key with the new high score
            highScore.text = score.ToString(); // update the "highScore" Text object's text with the new high score
        }

        // reset the high score if the K key is pressed
        if (Input.GetKeyDown(KeyCode.K))
        {
            PlayerPrefs.DeleteKey("HighScore"); // delete the "HighScore" PlayerPrefs key
            highScore.text = "0"; // set the "highScore" Text object's text to 0
        }
    }

    // reset the high score to 0
    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore"); // delete the "HighScore" PlayerPrefs key
        highScore.text = "0"; // set the "highScore" Text object's text to 0
    }
}
