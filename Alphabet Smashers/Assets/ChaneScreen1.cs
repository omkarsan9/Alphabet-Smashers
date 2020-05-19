using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChaneScreen1 : MonoBehaviour
{

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex = 0 );
        FindObjectOfType<GameScore>().ResetGame();
    }

    
}
