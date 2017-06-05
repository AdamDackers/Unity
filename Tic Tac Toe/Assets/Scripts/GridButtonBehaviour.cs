using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridButtonBehaviour : MonoBehaviour {

    private Button button;
    private GridSquareBehaviour gridSquare;

	// Use this for initialization
	void Start () {

        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnButtonClick()
    {
        Debug.Log(this.name + " has been clicked");
        //gridSquare.gameObject.GetComponent<Image>().color = Color.red;
        gridSquare.GetComponent<GridSquareBehaviour>().SetImage();
        button.gameObject.SetActive(false);
        
    }

    public void subGridSquare(GridSquareBehaviour rt)
    {
        this.gridSquare = rt;
    }


}
