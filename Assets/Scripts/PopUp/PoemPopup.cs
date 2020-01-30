using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoemPopup : MonoBehaviour
{
    private StagePlay m_StagePlay;

    private GameObject PoemButton;
    private GameObject PoemText;
    private GameObject PoemTitle;
    private GameObject NextButton;


    // 0 : 그냥 시만 나오고 끝...
    // 1 : 제목을 지저야지만이 넘어간다.
    private int iCount = 0;



    // Start is called before the first frame update
    void Start()
    {
        PoemButton = this.transform.GetChild(0).gameObject;
        PoemText = this.transform.GetChild(1).gameObject;
        PoemTitle = this.transform.GetChild(2).gameObject;
        NextButton = this.transform.GetChild(3).gameObject;

        m_StagePlay = FindObjectOfType<StagePlay>();
        //this.GetComponent<Button>().onClick.AddListener(delegate { m_StagePlay.fowardDown(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    //========================================================================================================//
    //================================================= BUTTONS ================================================//
    //========================================================================================================//

    public void ReadPoemButtonEvent()
    {
        PoemButton.SetActive(false);
        PoemTitle.SetActive(false);
        PoemText.SetActive(true);        
        NextButton.SetActive(true);
    }


    public void NextButtonEvent()
    {
        if(0 == iCount)
        {
            m_StagePlay.forwardDown();
            iCount++;
            PoemTitle.SetActive(true);
        }
        else if(1 == iCount)
        {
            string tmpText = PoemTitle.transform.GetChild(2).gameObject.transform.GetComponent<Text>().text;
            if ("" == tmpText)
            {                
                //PoemText.transform.GetComponent<Text>().text = "hmm...";
                return;
            }            
            m_StagePlay.forwardDown();
        }
         
    }
}
