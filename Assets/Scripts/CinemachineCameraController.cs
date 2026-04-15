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
        NextCam();
    }
    
    public void NextCam()
    {
        counter += Time.deltaTime;
        switch (Numcam)
        {           
            case Cameras.Camera_1:
                if(counter>=10)
                {
                    Numcam = Cameras.Camera_2;
                    camB.Priority = 30;
                    CamerasCount ++;
                }
                break;

            case Cameras.Camera_2:
                if(counter>=20)
                {
                    Numcam = Cameras.Camera_3;
                    camC.Priority = 40;
                    CamerasCount ++;
                }
                break;

            case Cameras.Camera_3:
                if(counter>=25)
                {
                    Numcam = Cameras.CameraDefault;                   
                    camD.Priority = 50;                   
                    CamerasCount ++;                   
                }
                
                break;
            case Cameras.CameraDefault:               
                //ResetCam();
                counter *= 0;
                break;
        }
    }
    
    public void ResetCam()
    {
        camA.Priority = 10;
        camB.Priority = 10;
        camC.Priority = 10;
        camD.Priority = 10;      
        CamerasCount = 1;       
    }
}
