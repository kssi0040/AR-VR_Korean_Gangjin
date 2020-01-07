using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapPopup : MonoBehaviour
{
    private Button[] aButtons = new Button[6];
    private GameObject[] aXMark = new GameObject[6];
    private StagePlay StagePlaySc = null;

    // hmm.....
    private void Awake()
    {
        for (int i = 0; i < aButtons.Length; ++i)
        {
            aButtons[i] = this.transform.GetChild(i).gameObject.transform.GetComponent<Button>();
            aXMark[i] = this.transform.GetChild(i).gameObject.transform.GetChild(1).gameObject;
            aXMark[i].SetActive(false);
        }
        StagePlaySc = GameObject.Find("StagePlay").GetComponent<StagePlay>();
        Debug.Log("Map Popup Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Popup 활성화마다 call 된다.,    
    private void OnEnable()
    {
        Debug.Log("Map Popup Open");
        if (null == StagePlaySc)
        {
            StagePlaySc = GameObject.Find("StagePlay").GetComponent<StagePlay>();
        }

        int iIndex = StagePlaySc.Index;                

        for(int i = 0; i < aXMark.Length; ++i)
        {
            aXMark[i].SetActive(true);
            aButtons[i].enabled = false;
        }

        // index 로 컨트롤 한다.
        // 해당 index에 따라서... 버튼 On/Off 한다.        
        if(20 == iIndex)                                // 돌담..
        {
            aXMark[2].SetActive(false);
            aButtons[2].enabled = true;
        }
        else if(37 == iIndex)
        {
            aXMark[0].SetActive(false);
            aButtons[0].enabled = true;
        }
        else if (54 == iIndex)
        {
            aXMark[5].SetActive(false);
            aButtons[5].enabled = true;
        }
        else if (56 == iIndex)
        {
            aXMark[4].SetActive(false);
            aButtons[4].enabled = true;
        }
        else if (58 == iIndex)
        {
            aXMark[1].SetActive(false);
            aButtons[1].enabled = true;
        }
        else if (60 == iIndex)
        {
            aXMark[3].SetActive(false);
            aButtons[3].enabled = true;
        }
    }




    public void SetIndex(int _iIndex)
    {
        // hmm......
        for (int i = 0; i < aButtons.Length; ++i)
        {
            aButtons[i].enabled = false;
        }
    }

}
