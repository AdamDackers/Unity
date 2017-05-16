using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerBehaviour : MonoBehaviour {

    PlayerBehaviour[] players;
    int curPlayer;

    // Use this for initialization
    void Start() {
        players = new PlayerBehaviour[2];
        curPlayer = 0;
        SetupPlayers();
    }

    private void SetupPlayers()
    {
        for (int i = 0; i < players.Length; i++)
        {
            players[i] = new PlayerBehaviour();
            //nit player and their attributes
            System.Random rand = new System.Random();
            Color pc = new Color((float)rand.Next(255), (float)rand.Next(255), (float)rand.Next(255),255);
            players[i].setColor(pc);
        }
    }

    // Update is called once per frame
    void Update() {

    }
    public void turnEnd()
    {
        testGameEnd();
    }

    public void testGameEnd()
    {
        //game end logic
        if(curPlayer < players.Length -1)
        {
            curPlayer++;
        }
        else
        {
            curPlayer = 0;
        }
        
    }

    public Color getCurPlayerColor()
    {
        return players[curPlayer].getColor();
    }
}
