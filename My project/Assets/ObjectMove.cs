using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ObjectMove : MonoBehaviour
{
    //���������� ��� ����� � ��������� �������
    public float s;
    private void Start()
    {
        //����� f �����������, ��� ��� ���������� ��� ���������� float
        //�������� ����������� ������
        s = 0.13f;
    }
    private void FixedUpdate ()
    {
        //���������, ���� ������� ������ -7.5
        transform.position = new Vector3(transform.position.x - s, transform.position.y, 0);
        if (transform.position.x <= -17.5f)
        {
            //�� ���������� ������
            //Destroy(gameObject);-1.30712
        }
    }
}
