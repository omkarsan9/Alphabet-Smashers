using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField]int breakableblocks;
    ChaneScreen sceneloader;
    
    // Start is called before the first frame update
    private void Start()
    {
        sceneloader = FindObjectOfType<ChaneScreen>();
    }
    
    
    
    public void CountBreakableBlocks()
    {
        breakableblocks++;
       
    }


    public void NextLevel()
    {
        breakableblocks--;
        if(breakableblocks<=0)
        {
            sceneloader.LoadNextScene();
        }
    }
}
