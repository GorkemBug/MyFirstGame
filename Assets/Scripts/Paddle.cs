using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float minX = 0f;
    [SerializeField] float maxX = 16f;
    [SerializeField] float ScreenWidthInUnits = 16f;
  
    
    //cached references
    private AutoPlay theAutoPlay;
    private Ball theBall;
    
    // Start is called before the first frame update
    void Start()
    {
        theAutoPlay = FindObjectOfType<AutoPlay>();
        theBall = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(GetXPos(), minX, maxX);
        transform.position = paddlePos;
    }

    private float GetXPos()
    {
        if (theAutoPlay.IsAutoPlayEnabled())
        {
            return theBall.transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * ScreenWidthInUnits;
        }
            
    }
    
}
