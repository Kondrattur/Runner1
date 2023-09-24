using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //объ€л€ем переменную
    public GameObject objects;
    //функци€ старт
    private void Start()
    {
        InvokeRepeating("CreateObjects", 1,1);
    }

    void CreateObjects()
    {
        //спавним оъект на координатах
        Instantiate(objects, new Vector3(8.1f, 3.228268f, 0) , Quaternion.identity);
    }
}