using UnityEngine;
using SpatialSys.UnitySDK;

public class MoveToLocation : MonoBehaviour
{
    public void TPPlayerAvatar(Transform pointPosition)
    {
        var localAvatar = SpatialBridge.actorService.localActor.avatar;
        localAvatar.position = pointPosition.position;

    }
}
