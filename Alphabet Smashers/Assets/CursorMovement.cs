using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float Screenwidth = 16f;
    float xMin = 1.3f;
    float xMax = 14.7f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //print(Input.mousePosition.x / Screen.width*Screenwidth);
       
        Vector2 paddlepos = new Vector2(transform.position.x, 0.2f);
        paddlepos.x = Mathf.Clamp(GetXPos(), xMin, xMax);
        transform.position = paddlepos;
    }

    private float GetXPos()
    {
        if(FindObjectOfType<GameScore>().IsAutoPlayEnabled())
        {
            return FindObjectOfType<BalLaunch>().transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * Screenwidth;
        }
    }
}
