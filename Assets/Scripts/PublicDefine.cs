using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PublicDefine
{
    public enum AR_MODE
    {
        NONE = -1,
        TRACKING,
        PICKING,
    }    

    // 각각 event 순서.. Scene 이라고 할 수 있음...
    public enum ROUTE
    {
        NONE = -1,
        TABLE_SETTING,
        SELECT_FOOD,
        PICKED_FOOD,
        DRESS_EVENT,
    }
    // 아래는 삭제 예정...
    public enum STORY_PART
    {
        NONE = -1,
        START,
        PROLOGUE,
        STORY_1,
        STORY_2,
        AR_MODE_WALL,                           // AR Mode 1
        AR_MODE_FLOWER,                      // AR Mode 1

        // 사진 찍기...
        PHOTO_MOON,
        PHOTO_FLOWER,
        PHOTO_MAPLE,
        PHOTO_WELL,
    }


}
