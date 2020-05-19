using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalLaunch : MonoBehaviour
{
    int button = 0;
    [SerializeField] CursorMovement paddle1;
    // Start is called before the first frame update

    Vector2 Ballpos;
    bool hasstarted = false;
    void Start()
    {
        Ballpos = transform.position - paddle1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!hasstarted)
        {
            
            temp();

            launch();
        }
       
    }

    public void launch()
    {
        
        if (Input.GetMouseButtonDown(button)) 
        {
            hasstarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(1f,20f);
        }
    }

    public void temp()
    {
        Vector2 paddlepos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlepos + Ballpos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
    }

}
