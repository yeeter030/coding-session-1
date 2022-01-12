using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPCTrack : TPCBase
{
    public TPCTrack(Transform cameraTransform, Transform playerTransform) : base(cameraTransform, playerTransform)
    {

    }
    public override void Frame()
    {
        Vector3 targetPos = mPlayerTransform.position;
        targetPos.y += GameConstants.CameraPositionOffset.y;
        mCameraTransform.LookAt(targetPos);

    }
}