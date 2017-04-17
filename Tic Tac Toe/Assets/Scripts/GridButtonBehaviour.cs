using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridButtonBehaviour : MonoBehaviour {

    private Button button;

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
        button.gameObject.SetActive(false);
        
    }


}
