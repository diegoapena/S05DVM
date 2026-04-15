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
    public CinemachineCamera CameraPlayer;

    public float tiempoPorCamara = 5f;

    private int paso = 0;
    private float timer = 0f;

    void Start()
    {
        ActivarCamara(0);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= tiempoPorCamara)
        {
            timer = 0f;
            paso++;

            ActivarCamara(paso);
        }
    }

    void ActivarCamara(int x)
    {
        camA.Priority = 0;
        camB.Priority = 0;
        camC.Priority = 0;
        camD.Priority = 0;
        camE.Priority = 0;
        CameraPlayer.Priority = 0;

        switch (x)
        {
            case 0:
                camA.Priority = 10;
                break;
            case 1:
                camB.Priority = 10;
                break;
            case 2:
                camC.Priority = 10;
                break;
            case 3:
                camD.Priority = 10;
                break;
            case 4:
                camE.Priority = 10;
                break;
            case 5:
                CameraPlayer.Priority = 10;

                break;
        }
    }
}


































        /*
        public CinemachineCamera camA;
        public CinemachineCamera camB;
        public CinemachineCamera camC;
        public CinemachineCamera camD;
        public CinemachineCamera camE;

        private int currentCameraIndex = 1; // Índice de la cámara actual

        void Start()
        {
            SetCameraPriority(currentCameraIndex);
        }

        [Button]
        public void SwitchCamera()
        {
            currentCameraIndex++; // Incrementa el índice
            if (currentCameraIndex > 5) currentCameraIndex = 1; // Reinicia el índice si supera el número de cámaras

            SetCameraPriority(currentCameraIndex);
        }

        private void SetCameraPriority(int cameraIndex)
        {
            // Cambia la prioridad de las cámaras según el índice
            switch (cameraIndex)
            {
                case 1:
                    camA.Priority = 10;
                    camB.Priority = 0;
                    camC.Priority = 0;
                    camD.Priority = 0;
                    camE.Priority = 0;
                    break;
                case 2:
                    camA.Priority = 0;
                    camB.Priority = 10;
                    camC.Priority = 0;
                    camD.Priority = 0;
                    camE.Priority = 0;
                    break;
                case 3:
                    camA.Priority = 0;
                    camB.Priority = 0;
                    camC.Priority = 10;
                    camD.Priority = 0;
                    camE.Priority = 0;
                    break;
                case 4:
                    camA.Priority = 0;
                    camB.Priority = 0;
                    camC.Priority = 0;
                    camD.Priority = 10;
                    camE.Priority = 0;
                    break;
                case 5:
                    camA.Priority = 0;
                    camB.Priority = 0;
                    camC.Priority = 0;
                    camD.Priority = 0;
                    camE.Priority = 10;
                    break;
            }
        }
        */
    
