using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ObjectMove : MonoBehaviour
{
    //переменная для чисел с плавающей запятой
    public float s;
    private void Start()
    {
        //буква f обязательна, так как обозначает тип переменной float
        //скорость перемещения камеры
        s = 0.13f;
    }
    private void FixedUpdate ()
    {
        //проверяем, если позиция больше -7.5
        transform.position = new Vector3(transform.position.x - s, transform.position.y, 0);
        if (transform.position.x <= -17.5f)
        {
            //то уничтожаем объект
            //Destroy(gameObject);-1.30712
        }
    }
}
