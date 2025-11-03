using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private bool isONMainMenu;
    [SerializeField] private bool isPaused;
    [SerializeField] GameObject pauseMenu;

    public void PauseButton()
    {
        if (isPaused)
        {
            isPaused = !isPaused;
            pauseMenu.SetActive(isPaused);
            Time.timeScale = isPaused ? 0 : 1;
        }
        else
        {
            isPaused = !isPaused;
            pauseMenu.SetActive(isPaused);
            Time.timeScale = isPaused ? 0 : 1;
        }
    }
    
}
