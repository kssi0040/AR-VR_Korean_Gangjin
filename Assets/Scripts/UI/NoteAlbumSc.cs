using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteAlbumSc : MonoBehaviour
{
    public Animator noteAnim;
    public Texture2D testTexture;

    private GameObject[] aPhotos = new GameObject[6];
    private SpriteRenderer[] aPhotoImages = new SpriteRenderer[6];

    private GameObject[] aBigPhotos = new GameObject[6];
    private SpriteRenderer[] aBigPhotoImages = new SpriteRenderer[6];

    public Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        noteAnim = this.transform.GetChild(0).gameObject.transform.GetComponent<Animator>();
        //this.transform.localPosition = new Vector3(0f, 2.5f, 3.1f);        
        this.transform.localPosition = new Vector3(0f, 5.0f, 3.1f);
        mainCamera = GameObject.FindObjectOfType<Camera>();

        for (int i = 0; i < aPhotos.Length; ++i)
        {
            aPhotos[i] = this.transform.GetChild(1).transform.GetChild(i).gameObject;
            aPhotoImages[i] = aPhotos[i].transform.GetComponent<SpriteRenderer>();

            aBigPhotos[i] = this.transform.GetChild(2).transform.GetChild(i).gameObject;
            aBigPhotoImages[i] = aBigPhotos[i].transform.GetComponent<SpriteRenderer>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("hmm");        
       if(1 == Input.touchCount)
        {
            Debug.Log("haha");
        }

        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            //Ray ray = mainCamera.ScreenPointToRay(Input.GetTouch(0).position);            
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            bool bCheck = Physics.Raycast(ray, out hit, 30f);
            if (true == bCheck)
            {
                string name = hit.collider.gameObject.name;
                Debug.Log("name: " + name);
                // 여기서 체크한다.
                // 작은 사진.....
                if ("photo_sprite_1" == name) {
                    Texture2D tmpTexture = PhotoContainer.Instance.GetPhoto(0);
                    if (null == tmpTexture)
                        return;

                    ViewBigPhoto(0);
                }
                else if ("photo_sprite_2" == name)
                {
                    Texture2D tmpTexture = PhotoContainer.Instance.GetPhoto(1);
                    if (null == tmpTexture)
                        return;

                    ViewBigPhoto(1);
                } else if ("photo_sprite_3" == name)
                {
                    Texture2D tmpTexture = PhotoContainer.Instance.GetPhoto(2);
                    if (null == tmpTexture)
                        return;

                    ViewBigPhoto(2);
                }
                else if ("photo_sprite_4" == name)
                {
                    Texture2D tmpTexture = PhotoContainer.Instance.GetPhoto(3);
                    if (null == tmpTexture)
                        return;

                    ViewBigPhoto(3);
                } else if ("photo_sprite_5" == name)
                {
                    Texture2D tmpTexture = PhotoContainer.Instance.GetPhoto(4);
                    if (null == tmpTexture)
                        return;

                    ViewBigPhoto(4);
                }
                else if ("photo_sprite_6" == name)
                {
                    Texture2D tmpTexture = PhotoContainer.Instance.GetPhoto(5);
                    if (null == tmpTexture)
                        return;

                    ViewBigPhoto(5);
                }

                // 큰 사진...
                if ("big_photo_sprite_1" == name || "big_photo_sprite_2" == name || "big_photo_sprite_3" == name || "big_photo_sprite_4" == name || "big_photo_sprite_5" == name || "big_photo_sprite_6" == name)
                {
                    ViewMyPhotos();
                }
            }
        }
    }

    void ViewBigPhoto(int _iIndex)
    {
        int iIndex = _iIndex;
        for (int i = 0; i < aPhotos.Length; ++i)
        {
            aPhotos[i].SetActive(false);
        }

        Texture2D tmpTexture = PhotoContainer.Instance.GetPhoto(iIndex);
        aBigPhotos[iIndex].SetActive(true);        
        Texture2D tmpPhotoTexture = ScaleTexture(tmpTexture, 1600, 960);
        //aBigPhotoImages[iIndex].sprite = Sprite.Create(tmpPhotoTexture, new Rect(0f, 0f, tmpPhotoTexture.width, tmpPhotoTexture.height), new Vector2(0.5f, 0.5f), 100f);        
        aBigPhotoImages[iIndex].sprite = Sprite.Create(tmpPhotoTexture, new Rect(0f, 0f, 1600f, 960f), new Vector2(0.5f, 0.5f));
        aBigPhotos[iIndex].transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        //aBigPhotos[iIndex].transform.eulerAngles = new Vector3(180f, 0f, 0f);
        aBigPhotos[iIndex].transform.eulerAngles = new Vector3(0f, 0f, 0f);
    }

    public void FoldNote()
    {
        noteAnim.SetTrigger("close");        
    }

    public void ViewMyPhotos()
    {
        for (int i = 0; i < aPhotos.Length; ++i)
        {
            aPhotos[i].SetActive(true);
        }
        for(int i = 0; i < aBigPhotos.Length; ++i)
        {
            aBigPhotos[i].SetActive(false);
        }
        
        //Texture2D tmpTexture = PlayerInfo.Instance.GetPhoto(0);
        //testSc.material.SetTexture(tmpTexture.name, tmpTexture);
        for(int i = 0; i < aPhotos.Length; ++i)
        {            
            Texture2D tmpTexture = PhotoContainer.Instance.GetPhoto(i);
            if (null == tmpTexture)
            {
                //Debug.Log("null photo");
                aPhotos[i].SetActive(false);
            }
            else if(null != tmpTexture)
            {
                aPhotos[i].SetActive(true);
                Texture2D tmpPhotoTexture = ScaleTexture(tmpTexture, 400, 240);
                //aPhotoImages[i].sprite = Sprite.Create(tmpPhotoTexture, new Rect(0f, 0f, tmpPhotoTexture.width, tmpPhotoTexture.height), new Vector2(0.5f, 0.5f), 100f);                                
                aPhotoImages[i].sprite = Sprite.Create(tmpPhotoTexture, new Rect(0f, 0f, 400f, 240f), new Vector2(0.5f, 0.5f));
                aPhotos[i].transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
                //aPhotos[i].transform.eulerAngles= new Vector3(180f, 0f, 0f);
                aPhotos[i].transform.eulerAngles = new Vector3(0f, 0f, 0f);
            }
        }                   
    }


    public void FoldMyPhoto()
    {
        for (int i = 0; i < aPhotos.Length; ++i)
        {
            aPhotos[i].SetActive(false);
        }
    }



    // hmm....
    // 여기서 사진을 가져온다.


    // 사진을 가져와야 한다...
    // 문제는 사진을 어디서 저장하느냐...??
    // 그리고 그 사진을 어디서 받아오느냐..??

    Texture2D ScaleTexture(Texture2D source, int targetWidth, int targetHeight)
    {
        Texture2D result = new Texture2D(targetWidth, targetHeight, source.format, true);
        Color[] rpixels = result.GetPixels(0);
        float incX = (1.0f / (float)targetWidth);
        float incY = (1.0f / (float)targetHeight);
        for (int px = 0; px < rpixels.Length; px++)
        {
            rpixels[px] = source.GetPixelBilinear(incX * ((float)px % targetWidth), incY * ((float)Mathf.Floor(px / targetWidth)));
        }
        result.SetPixels(rpixels, 0);
        result.Apply();
        return result;
    }


}
