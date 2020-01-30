using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollTitlePopup : MonoBehaviour
{

    public Text titleText;
    private StagePlay m_StagePlay;

    private bool bStart = false;


    // 후에 Tween....
    private void OnEnable()
    {
        if (false == bStart)
            return;
    }


    // Start is called before the first frame update
    void Start()
    {
        m_StagePlay = FindObjectOfType<StagePlay>();
        //this.GetComponent<Button>().onClick.AddListener(delegate { m_StagePlay.fowardDown(); });
        bStart = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CompleteButtonEvent()
    {
        if ("" == titleText.text)
        {
            Debug.Log("not yet...");
            return;
        }

        m_StagePlay.forwardDown();
    }
}
