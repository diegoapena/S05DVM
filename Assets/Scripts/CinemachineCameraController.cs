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
                }
                break;
            case Cameras.Camera_2:
                if(counter>=20)
                {
                    Numcam = Cameras.Camera_3;
                    camC.Priority = 40;                    
                }
                break;

            case Cameras.Camera_3:
                if(counter>=25)
                {
                    Numcam = Cameras.CameraDefault;                   
                    camD.Priority = 50;                                                     
                }
                
                break;
            case Cameras.CameraDefault:               
                
                GameManager.Instance.playerController.OnMove();                
                counter *= 0;
                break;
        }
    }
        
}
