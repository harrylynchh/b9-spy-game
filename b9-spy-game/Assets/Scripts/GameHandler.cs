//TODO: Uncomment PlayerHurt component stuff

using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{

      private GameObject player;
      public float playerLightLevel = 1f;
      public bool isDefending = false;

      public static bool stairCaseUnlocked = false;
      //this is a flag check. Add to other scripts: GameHandler.stairCaseUnlocked = true;

      private string sceneName;
      public static string lastLevelDied;  //allows replaying the Level where you died
      public bool isInLight = false;
      public int inventoryCt = 0;
      void Start()
      {
            player = GameObject.FindWithTag("Player");
            sceneName = SceneManager.GetActiveScene().name;
            playerLightLevel = 1f;
            //if (sceneName=="MainMenu"){ //uncomment these two lines when the MainMenu exists
            //}
      }
      void FixedUpdate()
      {
            if (inventoryCt == 5)
            {
                  SceneManager.LoadScene("EndWin");

            }
            if (isInLight)
            {
                  Debug.Log("DECREMENTING");
                  playerLightLevel -= 0.005f;
            }
            else
            {
                  Debug.Log("INCREMENTING");
                  playerLightLevel += 0.005f;
            }
            playerLightLevel = Mathf.Clamp(playerLightLevel, 0f, 1f);
            if (playerLightLevel == 0f)
            {
                  playerDies();
            }
      }
      public void playerDies()
      {
            // player.GetComponent<PlayerHurt>().playerDead();       //play Death animation
            lastLevelDied = sceneName;
            inventoryCt = 0;       //allows replaying the Level where you died
            StartCoroutine(DeathPause());
      }

      public void SetInLight(bool state)
      {
            isInLight = state;
            Debug.Log("Player in light: " + isInLight);
      }

      IEnumerator DeathPause()
      {
            player.GetComponent<PlayerMove>().isAlive = false;
            player.GetComponent<PlayerJump>().isAlive = false;
            yield return new WaitForSeconds(1.0f);
            SceneManager.LoadScene("EndLose");
      }

      public void StartGame()
      {
            Debug.Log("StartGame clicked");
            inventoryCt = 0;
            SceneManager.LoadScene("Level1");
            // SceneManager.LoadScene("Tutorial");
      }

      // Return to MainMenu
      public void RestartGame()
      {
            Time.timeScale = 1f;
            inventoryCt = 0;
            GameHandler_PauseMenu.GameisPaused = false;
            SceneManager.LoadScene("MainMenu");
            // Reset all static variables here, for new games:
      }

      // Return to MainMenu
      public void BackToMainMenu()
      {
            inventoryCt = 0;
            Time.timeScale = 1f;
            SceneManager.LoadScene("MainMenu");
      }

      // Replay the Level where you died
      public void ReplayLastLevel()
      {
            Time.timeScale = 1f;
            inventoryCt = 0;
            GameHandler_PauseMenu.GameisPaused = false;
            SceneManager.LoadScene(lastLevelDied);
            // Reset all static variables here, for new games:
      }

      public void QuitGame()
      {
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
      }

      public void Credits()
      {
            Debug.Log("Credits clicked");
            SceneManager.LoadScene("Credits");
      }
}