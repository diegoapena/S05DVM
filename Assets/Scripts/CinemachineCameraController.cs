using Sirenix.OdinInspector;
using Unity.Cinemachine;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Splines;
public enum Cameras
{
    Camera_1,
    Camera_2,
    Camera_3, 
    Camera_4,
    CameraDefault,
}
public class CinemachineCameraController : MonoBehaviour
{
    public CinemachineCamera camA;
    public CinemachineCamera camB;
    public CinemachineCamera camC;
    public CinemachineCamera camD;
    public Cameras Numcam;
    public float counter;
    public int CamerasCount;
    void Start()
    {

    }


    void Update()
    {
        SwitchCamera();
    }

    public void SwitchCamera()
    {
        
        counter += Time.deltaTime;
        NextCam();
    }
    
    public void NextCam()
    {
        switch (Numcam)
        {
            case Cameras.Camera_1:
                if (counter>=10)
                {
                    Numcam= Cameras.Camera_2;
                    camA.Priority = 20;                  
                }
                break;

            case Cameras.Camera_2:
                if(counter>=20)
                {
                    Numcam = Cameras.Camera_3;
                    camB.Priority = 30;
                    CamerasCount = 2;
                }
                break;

            case Cameras.Camera_3:
                if(counter>=30)
                {
                    Numcam = Cameras.Camera_4;
                    camC.Priority = 40;
                    CamerasCount = 3;
                }
                break;

            case Cameras.Camera_4:
                if(counter>=40)
                {

                    camD.Priority = 50;
                    Numcam = Cameras.CameraDefault;
                    CamerasCount = 4;
                }
                break;
            case Cameras.CameraDefault:
                if(counter>=50)
                {
                    ResetCam();                   
                    Numcam = Cameras.Camera_1;                  
                } 
                break;
        }
    }
    
    public void ResetCam()
    {
        camA.Priority = 10;
        camB.Priority = 10;
        camC.Priority = 10;
        camD.Priority = 10;
        counter = 0;
        CamerasCount = 1;
    }
}
