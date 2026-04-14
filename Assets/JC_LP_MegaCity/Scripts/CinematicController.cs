using Unity.Cinemachine;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityEngine.ProBuilder.MeshOperations;

public class CinematicController : MonoBehaviour
{
    public CinemachineCamera camA;
    public CinemachineCamera camB;
    public CinemachineCamera camC;
    public CinemachineCamera camD;
    public CinemachineCamera camE;
    void Start()
    {
        
    }

    [Button]
    public void SwitchCamera()
    {
        if (camB.Priority > camA.Priority)
        {
            camB.Priority = 10;
            camA.Priority = 20;
            camC.Priority = 30;
            camD.Priority = 40;
            camE.Priority = 50;
        }
        else 
        {
            camB.Priority = 20;
            camA.Priority = 10;
            camC.Priority = 40;
            camD.Priority = 50;
            camE.Priority = 100;
        }
        
    }
}
