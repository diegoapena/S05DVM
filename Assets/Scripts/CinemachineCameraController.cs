using UnityEngine;
using Sirenix.OdinInspector;
using Unity.Cinemachine;
using UnityEngine.Splines;
public enum Cameras
{
    Camera_1,
    Camera_2,
    Camera_3, 
    Camera_4
}
public class CinemachineCameraController : MonoBehaviour
{
    public CinemachineCamera camA;
    public CinemachineCamera camB;
    public Cameras Numcam;
    public float switchTime;
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
        counter += Time.deltaTime;
        if (camB.Priority > camA.Priority)
        {         
            camB.Priority = 10;
            camA.Priority = 20;
            
        }
        if (counter >= switchTime)
        {               
             camB.Priority = 20;
             camA.Priority = 10;          
        }      
        /*
        else
        {
            camB.Priority = 20;
            camA.Priority = 10;
        }  */
    }
    /*
    public void ChangeCam()
    {
        switch (Cameras)
        {
            case.Camera_1:
            {
                
            }
        }
    }
    */

}
