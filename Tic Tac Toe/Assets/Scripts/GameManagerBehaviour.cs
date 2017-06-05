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
            //init player and their attributes
            Color pc = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f),1);
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
