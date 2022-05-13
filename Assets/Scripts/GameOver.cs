using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI roundsText;

    void OnEnable()
    {
        roundsText.text = PlayerStats.Rounds.ToString();
    }

    public void Retry ()
    {
        SceneManager.LoadScene(0);
    }

    public void Menu ()
    {
        Debug.Log("Menu");
    }
}
