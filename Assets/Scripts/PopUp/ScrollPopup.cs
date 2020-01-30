using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScrollPopup : MonoBehaviour
{        
    public GameObject ScrollObject = null;
    public int iPopupIndex;
    public Text titleText;

    private GameObject buttonPopup;    
    private GameObject PoemButton;    
    private GameObject NoticePopup;
    private GameObject TitleInput;
    private StagePlay stagePlaySc;


    private void Awake()
    {
        buttonPopup = this.transform.GetChild(0).gameObject;
        PoemButton = this.transform.GetChild(1).gameObject;
        TitleInput = this.transform.GetChild(2).gameObject;
        NoticePopup = this.transform.GetChild(3).gameObject;        
    }

    private void OnEnable()
    {
        buttonPopup.SetActive(true);
        PoemButton.SetActive(false);        
        TitleInput.SetActive(false);        
        NoticePopup.SetActive(false);
    }


    // Start is called before the first frame update
    void Start()
    {
        // test...
        stagePlaySc = GameObject.FindObjectOfType<StagePlay>();
        ScrollObject = stagePlaySc.ScrollObject;        
    }

    // Update is called once per frame
    void Update()    {    }

    public void OpenPopupButtonEvent()
    {
        buttonPopup.SetActive(false);        
        ScrollObject.SetActive(true);
        Invoke("PeomOpen", 0.6f);
    }

    void PeomOpen()
    {
        if (0 == iPopupIndex)
        {
            PoemButton.SetActive(true);
        }
        else if(1 == iPopupIndex)
        {
            PoemButton.SetActive(true);
            TitleInput.SetActive(true);
        }        
    }




    public void PoemButtonEvent()
    {
        if(0 == iPopupIndex)
        {
            // 그냥 fold...
            //noteAlbum.transform.GetComponent<NoteAlbumSc>().FoldNote();
            PoemButton.SetActive(false);
            ScrollObject.GetComponent<NTweenScale>().PlayReverse();
            Invoke("FoldComplete", 0.7f);
        }
        else if(1 == iPopupIndex)
        {
            // 제목을 지어야 함....
            string tmpText = titleText.text;
            if ("" == tmpText)
            {
                NoticePopup.SetActive(true);
            }
            else
            {
                TitleInput.SetActive(false);
                PoemButton.SetActive(false);
                ScrollObject.GetComponent<NTweenScale>().PlayReverse();
                Invoke("FoldComplete", 0.7f);
            }
        }
    }
    public void NoticePopupButtonEvent()
    {
        NoticePopup.SetActive(false);
    }

    void FoldComplete()
    {                
        stagePlaySc.forwardDown();
    }





}
