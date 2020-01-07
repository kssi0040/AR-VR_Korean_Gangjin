﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectPopUp : MonoBehaviour
{
    public StagePlay m_StagePlay;

    private GameObject[] aButtons = new GameObject[3];
    private GameObject[] aShadowImgs = new GameObject[3];

    private int iIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        m_StagePlay = FindObjectOfType<StagePlay>();
        
        for (int i = 0; i < aButtons.Length; ++i)
        {
            aButtons[i] = this.transform.GetChild(i).gameObject;
            aButtons[i].transform.GetComponent<Button>().onClick.AddListener(delegate { this.OnButtonDown(); });
            aShadowImgs[i] = aButtons[i].transform.GetChild(1).gameObject;
        }

        for (int i = 0; i < aButtons.Length; ++i)
        {
            aButtons[i].transform.GetComponent<Button>().enabled = false;
            aShadowImgs[i].SetActive(true);
        }
        aButtons[0].transform.GetComponent<Button>().enabled = true;
        aShadowImgs[0].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonDown()
    {
        if (false == PlayerInfo.Instance.isComplite)
            return;


        // hmm...
        for (int i = 0; i < aButtons.Length; ++i)
        {
            aButtons[i].transform.GetComponent<Button>().enabled = false;
            aShadowImgs[i].SetActive(true);
        }

        iIndex++;
        if (3 <= iIndex)
        {
            //PlayerInfo.Instance.isComplite = true;
            m_StagePlay.forwardDown();
            return;
        }
            

        aButtons[iIndex].transform.GetComponent<Button>().enabled = true;
        aShadowImgs[iIndex].SetActive(false);


        //PlayerInfo.Instance.isComplite = true;
        m_StagePlay.forwardDown();
    }
}
