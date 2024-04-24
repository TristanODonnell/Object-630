using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager singleton;

    [SerializeField] private Enemy enemyPrefab;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private ScoreManager scoreManager;

    // Start is called before the first frame update

    private void Awake()
    {
        singleton = this;

        //Player p = FindObjectOfType<Player>();
        //p.GetHealthInformation().onDie.AddListener(StopGame);
    }
    private void Start()
    {
        
        StartCoroutine(SpawnEnemiesCoroutine());
    }

 
    public void StopGame()
    {
        StopAllCoroutines();
        scoreManager.RegisterHighScore();
     
    }
    public void AddScore()
    {
        //scoreManager.IncreaseScore();
    }

    IEnumerator SpawnEnemiesCoroutine()
    {
        yield return new WaitForSeconds(3);
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.5f, 3));

            Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            //or

            Vector2 randomPosition = Random.insideUnitCircle * 10f;

            Enemy tempEnemy= Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
            tempEnemy.GetHealthInformation().onDie.AddListener(scoreManager.IncreaseScore);
            
            tempEnemy.SetupEnemy(2, 4, 1);
        }
    }
}
