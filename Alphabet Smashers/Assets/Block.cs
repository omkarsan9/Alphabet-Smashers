using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;

public class Block : MonoBehaviour
{


    Level level;
    GameScore score;
    [SerializeField] int maxhits = 0;
    [SerializeField] int timeshit = 0;
    [SerializeField] Sprite[] hitsprite;
    private void Start()
    {
        level = FindObjectOfType<Level>();
       
        score = FindObjectOfType<GameScore>();

        if(tag == "Breakable")
        {
            level.CountBreakableBlocks();
        }




    }

    public void ShowSprite()
    {
        int x = timeshit-1;
        GetComponent<SpriteRenderer>().sprite = hitsprite[x];
    }
    
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
    
        if (tag == "Breakable")
        {
            timeshit++;
            if(timeshit==maxhits)
            {
                Destroy(gameObject);
                level.NextLevel();
            }
            else
            {
                ShowSprite();
            }
            
            score.addscore();



        }
        

    }
}
