using UnityEngine;
using TMPro; // TextMeshPro�� ����ϱ� ���� �߰�

public class BlockCollision : MonoBehaviour
{
    public TextMeshProUGUI displayText; // TextMeshProUGUI Ÿ������ ����

    void Start()
    {
        if (displayText != null)
        {
            displayText.gameObject.SetActive(false); // ó������ �ؽ�Ʈ�� ��Ȱ��ȭ
        }
    }

    // �÷��̾ �ݶ��̴��� �ε����� �� ȣ��Ǵ� �޼���
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (displayText != null)
            {
                //displayText.text = "��Ͽ� �ö�Խ��ϴ�!"; // ���ϴ� �ؽ�Ʈ ����
                displayText.gameObject.SetActive(true); // �ؽ�Ʈ Ȱ��ȭ
            }
        }
    }

    // �÷��̾ �ݶ��̴����� ������ �� ȣ��Ǵ� �޼���
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (displayText != null)
            {
                displayText.gameObject.SetActive(false); // �ؽ�Ʈ ��Ȱ��ȭ
            }
        }
    }
}
