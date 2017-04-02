using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBoardBehaviour : MonoBehaviour {

    private RectTransform gridPrefab;
    private RectTransform[] gridArray;

	// Use this for initialization
	void Start () {
        gridPrefab = Resources.Load("Prefabs/gridSquare",typeof(RectTransform)) as RectTransform;
        gridArray = new RectTransform[9];
        ResetPlaySpace();
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void ResetPlaySpace()
    {
        Debug.Log("starting reset PlaySpace");
        int spaceValue = 0;
        for(int i=0; i < gridArray.Length;i++)
        {
            if(i % 3 == 0)
            {
                spaceValue++;
            }
            gridArray[i] = Instantiate(gridPrefab);
            gridArray[i].SetParent(gameObject.transform);
            gridArray[i].gameObject.transform.localScale = gameObject.transform.localScale;
            //gridArray[i].gameObject.transform.Translate(gridArray[i].rect.width * spaceValue, gridArray[i].rect.height * spaceValue, gridArray[i].transform.transform.position.z);
        }
        

    }
}
