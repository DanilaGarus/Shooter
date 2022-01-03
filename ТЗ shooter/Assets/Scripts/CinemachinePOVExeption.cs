using Cinemachine;
using UnityEngine;

public class CinemachinePOVExeption : CinemachineExtension
{
    [SerializeField] private float hotizontalSpeed = 10f;
    [SerializeField] private float verticalSpeed = 10f;
    [SerializeField] private float clampAngle = 80f;
    private InputManager inputManager;
    private Vector3 startingRotation;

    protected override void Awake()
    {
        inputManager = InputManager.Instance;
        base.Awake();
    }

    // Использовал Aim в CinemachineCam. Код приведённый ниже заставляет ротейтиться
    // камеру по Input'у с мыши ( камера ротейтится вверх - вниз, а герой уже
    // поворачивается влево - вправо

    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (vcam.Follow)
        {
            if (stage == CinemachineCore.Stage.Aim)
            {
                if (startingRotation == null)
                {
                    startingRotation = transform.localRotation.eulerAngles;
                }
                Vector2 deltaInput = inputManager.GetMouseDelta();
                startingRotation.x += deltaInput.x * verticalSpeed * Time.deltaTime;
                startingRotation.y += deltaInput.y  * hotizontalSpeed * Time.deltaTime;
                startingRotation.y = Mathf.Clamp(startingRotation.y, -clampAngle, clampAngle);
                state.RawOrientation = Quaternion.Euler(-startingRotation.y, startingRotation.x, 0f);
            }
        }
    }
}