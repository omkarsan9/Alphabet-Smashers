using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameScore : MonoBehaviour
{
    [SerializeField] int currentscore = 0;
    int points = 1;
    [SerializeField] TextMeshProUGUI scoretext;
    [SerializeField] bool isAutoPlayEnabled;
    private void Awake()
    {
        int gamestatuscount = FindObjectsOfType<GameScore>().Length;
        if (gamestatuscount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = currentscore.ToString();
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addscore()
    {
        currentscore = currentscore + points;
        scoretext.text = currentscore.ToString();
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }

    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }
}
