using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSquareBehaviour : MonoBehaviour {

    Image img;
    GameManagerBehaviour gm;

    // Use this for initialization
    void Start () {
        img = GetComponent<Image>();
        gm = GameObject.Find("GameManager").GetComponent<GameManagerBehaviour>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetImage()
    {
        Color tmp = gm.getCurPlayerColor();
        img.color = tmp;
        //img.color = new Color(144, 144, 144);
        gm.GetComponent<GameManagerBehaviour>().testGameEnd();
    }

}
