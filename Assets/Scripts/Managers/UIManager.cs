using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{

    private Player player;
    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] private GameObject gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        player.GetHealthInformation().OnLifeChanged.AddListener(UpdateLifeText);
       
    }
    void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }
    public void ReloadGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
