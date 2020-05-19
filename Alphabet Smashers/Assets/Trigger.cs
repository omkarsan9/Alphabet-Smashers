using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter2D()
    {
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex =3);
    }
}
