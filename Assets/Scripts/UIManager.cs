using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape basıldı");
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
        }

    public void PauseGame()
    {
        isPaused = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    
    public void QuitGame()
    {
        Debug.Log("Oyun Kapatildi");
        Application.Quit();
    }
    }
