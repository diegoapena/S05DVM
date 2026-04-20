using Sirenix.OdinInspector;
using TMPro;
using Unity.Cinemachine;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Splines;
public enum Cameras
{
    
    Camera01,
    Camera02, 
    Camera03,
    CameraDefault,

}
public class CinemachineCameraController : MonoBehaviour
{
    public CinemachineCamera camA;
    public CinemachineCamera camB;
    public CinemachineCamera camC;
    public CinemachineCamera camD;
    public Cameras AllCameras;
    public float Seconds;
    public int Minutes;
    public TextMeshProUGUI textMesh;
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
        Seconds += Time.deltaTime;     
        textMesh.text ="Time : "+ Minutes.ToString() + ":" + Seconds.ToString("f0");
        switch (AllCameras)
        {           
            case Cameras.Camera01:
                if(Seconds>=10)
                {
                     AllCameras= Cameras.Camera02;
                    camB.Priority = 30;                    
                }
                break;
            case Cameras.Camera02:
                if(Seconds>=20)
                {
                    AllCameras= Cameras.Camera03;
                    camC.Priority = 40;                    
                }
                break;

            case Cameras.Camera03:
                if(Seconds>=25)
                {
                    AllCameras= Cameras.CameraDefault;                   
                    camD.Priority = 50;                                                     
                }
                
                break;
            case Cameras.CameraDefault:               
                
                GameManager.Instance.playerController.OnMove();
                
                Seconds = 25;
                break;
        }
    }
        
}
