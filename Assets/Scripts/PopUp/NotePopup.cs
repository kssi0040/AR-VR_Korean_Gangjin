using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePopup : MonoBehaviour
{
    public GameObject textBox;
    public GameObject nextButton = null;
    public GameObject fingerMark = null;
    public GameObject noteAlbum = null;


    private GameObject noteButton;
    private GameObject backButton;
    
    

    // Start is called before the first frame update
    void Start()
    {
        noteButton = this.gameObject.transform.GetChild(0).gameObject;
        backButton = this.gameObject.transform.GetChild(1).gameObject;
        
        textBox = GameObject.Find("TextBox");
        nextButton = GameObject.Find("forward");
        noteAlbum = GameObject.FindObjectOfType<StagePlay>().NoteAlbumSc.gameObject;                
        //noteAlbum = GameObject.Find("Note_Object");
        fingerMark = GameObject.Find("Finger_Mark_2");                
    }


    //========================================================================================================//
    //========================================================================================================//
    //========================================================================================================//


    void PhotoPopupView()
    {
        noteAlbum.transform.GetComponent<NoteAlbumSc>().ViewMyPhotos();        
    }

    void FoldComplete()
    {
        textBox.SetActive(true);
        nextButton.SetActive(true);
        noteButton.SetActive(true);

        backButton.SetActive(false);
        noteAlbum.SetActive(false);
    }

    //========================================================================================================//
    //============================================= BUTTON EVENT ================================================//
    //========================================================================================================//


    public void NoteButtonEvent()
    {
        textBox.SetActive(false);
        
        noteButton.SetActive(false);
        backButton.SetActive(true);
        noteAlbum.SetActive(true);

        if(null != nextButton)
            nextButton.SetActive(false);

        if (null != fingerMark)
            fingerMark.SetActive(false);
        
        Invoke("PhotoPopupView", 1.5f);
    }


    public void BackButtonEvent()
    {
        noteAlbum.transform.GetComponent<NoteAlbumSc>().FoldMyPhoto();
        noteAlbum.transform.GetComponent<NoteAlbumSc>().FoldNote();
        Invoke("FoldComplete", 1.5f);
    }

}
