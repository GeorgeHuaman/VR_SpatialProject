using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpatialSys.UnitySDK;
using System;
public class GameManager : MonoBehaviour
{
    public void DisableJump()
    {
        SpatialBridge.actorService.localActor.avatar.maxJumpCount = 0;
    }

}
