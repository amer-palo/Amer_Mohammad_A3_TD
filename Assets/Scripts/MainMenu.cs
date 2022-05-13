using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string leveltoLoad = "Mainscene";
    public void Play ()
    {
        SceneManager.LoadScene(leveltoLoad);
    }

    public void Quit ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
