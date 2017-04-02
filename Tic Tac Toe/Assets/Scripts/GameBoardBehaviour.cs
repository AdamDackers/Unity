﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBoardBehaviour : MonoBehaviour {

    private RectTransform gridPrefab;
    private RectTransform[] gridArray;

    private RectTransform rt;

	// Use this for initialization
	void Start () {

        rt = gameObject.GetComponent<RectTransform>();
        gridPrefab = Resources.Load("Prefabs/gridSquare",typeof(RectTransform)) as RectTransform;
        gridArray = new RectTransform[9];
        ResetPlaySpace();
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void ResetPlaySpace()
    {
        float size = rt.rect.size.x / 3;
        float spacingX = -size; //set x-1 size so that first loop run sets a 0
        float spacingY = 0;

        for(int i=0; i < gridArray.Length;i++)
        {
            if(i % 3 == 0)
            {
                spacingY = 0;
                spacingX += size;
            }
            else
            {
                spacingY -= size;
            }

            gridArray[i] = Instantiate(gridPrefab);
            gridArray[i].name = "grid" + i;
            gridArray[i].SetParent(gameObject.transform);
            gridArray[i].gameObject.transform.localScale = gameObject.transform.localScale;
            gridArray[i].sizeDelta = new Vector2(size, size);
            gridArray[i].gameObject.transform.localPosition = new Vector3(spacingX, spacingY, 0);

        }
        

    }
}
