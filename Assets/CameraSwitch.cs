using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera thirdPersonCamera;  // 3��Ī ī�޶�
    public Camera firstPersonCamera;  // 1��Ī ī�޶�

    private bool isThirdPerson = true;

    void Start()
    {
        // ������ �� 3��Ī ī�޶� Ȱ��ȭ�ϰ� 1��Ī ī�޶�� ��Ȱ��ȭ
        thirdPersonCamera.enabled = true;
        firstPersonCamera.enabled = false;
    }

    void Update()
    {
        // Y Ű �Է� ����
        if (Input.GetKeyDown(KeyCode.Y))
        {
            // ī�޶� ��ȯ
            isThirdPerson = !isThirdPerson;

            thirdPersonCamera.enabled = isThirdPerson;
            firstPersonCamera.enabled = !isThirdPerson;
        }
    }
}
