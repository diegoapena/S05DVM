using UnityEngine;
using Sirenix.OdinInspector;
using Unity.Cinemachine;
public class CinemachineCameraController : MonoBehaviour
{
    public CinemachineCamera camA;
    public CinemachineCamera camB;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void SwitchCamera()
    {
        if(camB.Priority > camA.Priority)
        {
            camB.Priority = 10;
            camA.Priority = 20;           
        }
        else
        {
            camB.Priority = 20;
            camA.Priority = 10;
        }        
    }
}
