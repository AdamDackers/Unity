using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    private Color color;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void setColor(Color color)
    {
        this.color = color;
    }
    public Color getColor()
    {
        return color;
    }
}
