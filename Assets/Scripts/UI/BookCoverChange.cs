using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookCoverChange : MonoBehaviour
{
    public GameObject horizonText;
    public GameObject verticalText;
    public Text horizonNumText;
    public Text verticalNumText;

    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;

    private Image CoverSprite;
    private GameObject numberButton;
    private GameObject colorButton;
    private GameObject positionButton;
    private GameObject backButton;
    private GameObject completeButton;


    private GameObject numberObject;
    private GameObject colorObject;
    private GameObject positionObject;




    private void Awake()
    {
        CoverSprite = this.transform.GetChild(1).gameObject.transform.GetComponent<Image>();
        numberButton = this.transform.GetChild(2).gameObject;
        colorButton = this.transform.GetChild(3).gameObject;
        positionButton = this.transform.GetChild(4).gameObject;
        backButton = this.transform.GetChild(5).gameObject;
        completeButton = this.transform.GetChild(9).gameObject;

        numberObject = this.transform.GetChild(6).gameObject;
        colorObject = this.transform.GetChild(7).gameObject;
        positionObject = this.transform.GetChild(8).gameObject;

        redSlider.value = 1f;
        greenSlider.value = 1f;
        blueSlider.value = 1f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //=======================================================================================================//
    //================================================== MAIN =================================================//
    //=======================================================================================================//
    public void NumberChangeButtonEvent()
    {
        numberButton.SetActive(false);
        colorButton.SetActive(false);
        positionButton.SetActive(false);

        numberObject.SetActive(true);
        backButton.SetActive(true);
        completeButton.SetActive(false);
    }
    public void ColorChangeButtonEvent()
    {
        numberButton.SetActive(false);
        colorButton.SetActive(false);
        positionButton.SetActive(false);

        colorObject.SetActive(true);
        backButton.SetActive(true);
        completeButton.SetActive(false);
    }
    public void PositionChangeButtonEvent()
    {
        numberButton.SetActive(false);
        colorButton.SetActive(false);
        positionButton.SetActive(false);

        positionObject.SetActive(true);
        backButton.SetActive(true);
        completeButton.SetActive(false);
    }
    public void BackButtonEvent()
    {
        numberButton.SetActive(true);
        colorButton.SetActive(true);
        positionButton.SetActive(true);

        numberObject.SetActive(false);
        colorObject.SetActive(false);        
        positionObject.SetActive(false);

        backButton.SetActive(false);
        completeButton.SetActive(true);
    }
    //=======================================================================================================//
    //=========================================== NUMBER CHANGE ===============================================//
    //=======================================================================================================//
    public void Number1ButtonEvent()
    {
        if(true == horizonText)
        {
            horizonNumText.text = "1";
        }
        else if(true == verticalText)
        {
            verticalNumText.text = "1";
        }
    }
    public void Number2ButtonEvent()
    {
        if (true == horizonText)
        {
            horizonNumText.text = "2";
        }
        else if (true == verticalText)
        {
            verticalNumText.text = "2";
        }
    }
    public void Number3ButtonEvent()
    {
        if (true == horizonText)
        {
            horizonNumText.text = "3";
        }
        else if (true == verticalText)
        {
            verticalNumText.text = "3";
        }
    }
    //=======================================================================================================//
    //=========================================== POSITION CHANGE ===============================================//
    //=======================================================================================================//
    public void HorizontalButtonEvent()
    {
        horizonText.SetActive(true);
        verticalText.SetActive(false);
    }
    public void VerticalButtonEvent()
    {
        horizonText.SetActive(false);
        verticalText.SetActive(true);
    }
    //=======================================================================================================//
    //============================================ COLOR CHANGE ================================================//
    //=======================================================================================================//
    public void RedSliderChange()
    {        
        CoverSprite.color = new Color(redSlider.value, greenSlider.value, blueSlider.value);        
    }
    public void GreenSliderChange()
    {        
        CoverSprite.color = new Color(redSlider.value, greenSlider.value, blueSlider.value);
    }
    public void BlueSliderChange()
    {        
        CoverSprite.color = new Color(redSlider.value, greenSlider.value, blueSlider.value);
    }

}
