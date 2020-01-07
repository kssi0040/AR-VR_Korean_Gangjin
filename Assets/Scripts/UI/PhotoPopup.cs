using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoPopup : MonoBehaviour
{


    // 삭제 예정...
    private GameObject[] aPhotos = new GameObject[6];
    private RawImage[] aPhotoImages = new RawImage[6];

    private SpriteRenderer testSc;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < this.transform.childCount; ++i)
        {
            aPhotos[i] = this.gameObject.transform.GetChild(i).gameObject;
            aPhotoImages[i] = aPhotos[i].transform.GetComponent<RawImage>();
            aPhotos[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ViewMyPhotos()
    {
        for (int i = 0; i < aPhotos.Length; ++i)
        {
            aPhotos[i].SetActive(true);
        }

        // hmm....
        //Texture2D tmpTexture = PlayerInfo.Instance.GetPhoto(0);
        Texture2D tmpTexture = PhotoContainer.Instance.GetPhoto(0);
        testSc.material.SetTexture(tmpTexture.name, tmpTexture);

        /*
        for(int i = 0; i < aPhotos.Length; ++i)
        {
            Texture2D tmpTexture = PlayerInfo.Instance.GetPhoto(i);
            if (null == tmpTexture)
            {
                // hmm...
                aPhotos[i].SetActive(false);
            }
            else if(null != tmpTexture)
            {
                aPhotos[i].SetActive(true);
                aPhotoImages[i].texture = tmpTexture;
            }
        }   
        */
    }


    public void FoldMyPhoto()
    {
        for (int i = 0; i < aPhotos.Length; ++i)
        {
            aPhotos[i].SetActive(false);
        }
    }
}
