using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //�������� ����������
    public GameObject objects;
    //������� �����
    private void Start()
    {
        InvokeRepeating("CreateObjects", 1,1);
    }

    void CreateObjects()
    {
        //������� ����� �� �����������
        Instantiate(objects, new Vector3(8.1f, 3.228268f, 0) , Quaternion.identity);
    }
}