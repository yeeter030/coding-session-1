using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this classs is the base class for all
//these classes are not monobehaviour classes
//and hence cannot be adde to the GameObject as component
//we will instantiate the concrete implementation of these 3rd person cameras in our
//thirdpersoncamera monobehaviour class
public class TPCBase
{
    //only 2 transforms required
    protected Transform mCameraTransform;
    protected Transform mPlayerTransform;

    //the constructor
    public TPCBase(Transform cameraTransform, Transform playerTransform)
    {
        mCameraTransform = cameraTransform;
        mPlayerTransform = playerTransform;
    }

    //virtual: allowing derive class to override function
    public virtual void Frame()
    {

    }
}
