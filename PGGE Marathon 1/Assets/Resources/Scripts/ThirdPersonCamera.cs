using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    [SerializeField]
    Transform mPlayerTransform;
    TPCBase myCamera;

    [SerializeField]
    public Vector3 CameraAngleOffset = new Vector3(0.0f, 0.0f, 0.0f);
    [SerializeField]
    public Vector3 CameraPositionOffset = new Vector3(0.0f, 2.0f, -3.0f);
    [SerializeField]
    public float Damping = 1.0f;

    public enum CameraType
    {
        TRACK,
        FOLLOW_POS,
        FOLLOW_POS_ROT,
    }
    [SerializeField]
    CameraType mCameraType = CameraType.TRACK;

    Dictionary<CameraType, TPCBase> myCameras = new Dictionary<CameraType, TPCBase>();
    // Start is called before the first frame update
    void Start()
    {
        myCameras.Add(CameraType.TRACK, new TPCTrack(transform, mPlayerTransform));
        myCameras.Add(CameraType.FOLLOW_POS, new TPCFollowTrackPosition(transform, mPlayerTransform));
        myCameras.Add(CameraType.FOLLOW_POS_ROT, new TPCFollowTrackPositionAndRotation(transform, mPlayerTransform));
        //myCamera = new TPCTrack(transform, mPlayerTransform);
        //myCamera = new TPCFollowTrackPosition(transform, mPlayerTransform);
        //myCamera = new TPCFollowTrackPositionAndRotation(transform, mPlayerTransform);

        GameConstants.Damping = Damping;
        GameConstants.CameraPositionOffset = CameraPositionOffset;
        GameConstants.CameraAngleOffset = CameraAngleOffset;

    }

    // Update is called once per frame
    private void LateUpdate()
    {
        myCameras[mCameraType].Frame();
        //myCamera.Frame();
    }
}
