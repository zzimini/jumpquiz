using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera thirdPersonCamera;  // 3인칭 카메라
    public Camera firstPersonCamera;  // 1인칭 카메라

    private bool isThirdPerson = true;

    void Start()
    {
        // 시작할 때 3인칭 카메라를 활성화하고 1인칭 카메라는 비활성화
        thirdPersonCamera.enabled = true;
        firstPersonCamera.enabled = false;
    }

    void Update()
    {
        // Y 키 입력 감지
        if (Input.GetKeyDown(KeyCode.Y))
        {
            // 카메라 전환
            isThirdPerson = !isThirdPerson;

            thirdPersonCamera.enabled = isThirdPerson;
            firstPersonCamera.enabled = !isThirdPerson;
        }
    }
}
