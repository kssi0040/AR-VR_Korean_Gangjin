using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PublicDefine;


public class PhotoContainer : MonoBehaviour
{
    private static PhotoContainer instance = null;
    private static readonly object padlock = new object();
    private Texture2D[] aTexArr = new Texture2D[6];
    //private STORY_PART eStoryPart = STORY_PART.NONE;
    
    public static PhotoContainer Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new PhotoContainer();
                }
                return instance;
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()    {    }


    // 따로 컨테이너 클래스를 만들어야 할 듯....
    // 사진 가져오기....
    // 버튼으로 변경해야 할 수도 있음....\    
    //=================================================================================================================//    
    public void AddTexture(Texture2D _tex, STORY_PART _eStoryPart)
    {
        if (STORY_PART.AR_MODE_WALL == _eStoryPart)
        {
            if (null != aTexArr[0])
            {
                Texture2D temp = aTexArr[0];
                Destroy(temp);
                aTexArr[0] = null;
            }
            aTexArr[0] = _tex;
            Debug.Log("add photo : AR_MODE_WALL");
        }
        else if (STORY_PART.AR_MODE_FLOWER == _eStoryPart)
        {
            if (null != aTexArr[1])
            {
                Texture2D temp = aTexArr[1];
                Destroy(temp);
                aTexArr[1] = null;
            }
            aTexArr[1] = _tex;
        }
        else if (STORY_PART.PHOTO_MOON == _eStoryPart)
        {
            if (null != aTexArr[2])
            {
                Texture2D temp = aTexArr[2];
                Destroy(temp);
                aTexArr[2] = null;
            }
            aTexArr[2] = _tex;
        }
        else if (STORY_PART.PHOTO_FLOWER == _eStoryPart)
        {
            if (null != aTexArr[3])
            {
                Texture2D temp = aTexArr[3];
                Destroy(temp);
                aTexArr[3] = null;
            }
            aTexArr[3] = _tex;
        }
        else if (STORY_PART.PHOTO_MAPLE == _eStoryPart)
        {
            if (null != aTexArr[4])
            {
                Texture2D temp = aTexArr[4];
                Destroy(temp);
                aTexArr[4] = null;
            }
            aTexArr[4] = _tex;
        }
        else if (STORY_PART.PHOTO_WELL == _eStoryPart)
        {
            if (null != aTexArr[5])
            {
                Texture2D temp = aTexArr[5];
                Destroy(temp);
                aTexArr[5] = null;
            }
            aTexArr[5] = _tex;
        }
    }
    public Texture2D GetPhoto(int _iIndex)
    {
        return aTexArr[_iIndex];
    }

}
