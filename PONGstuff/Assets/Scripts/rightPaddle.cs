﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightPaddle : MonoBehaviour
{
    public float scaler = 2;
    public Prect paddleR;
    private Color lPaddleColor = new Color(1, 1, 0, 1);

    // Start is called before the first frame update
    void Start()
    {
        paddleR = new Prect("Right Paddle", 900, 100, 10, 30, true, "PADDLE");
        Manager.colliderPrects.Add(paddleR);
    }

    // Update is called once per frame
    void Update()
    {
        paddleR.rect.y += -scaler * Input.GetAxis("Vertical2");
        if (paddleR.rect.y < 13) paddleR.rect.y = 13;
        if (paddleR.rect.y > Screen.height - 50) paddleR.rect.y = Screen.height - 50; 

        if (Manager.ballLocation.x > Screen.width / 2) //Paddle AI
        {
            //paddleR.rect.y = Manager.ballLocation.y - 15;
        }
    }

    private void OnGUI()
    {
        Manager.GUIDrawRect(paddleR.rect, lPaddleColor);
    }
}
