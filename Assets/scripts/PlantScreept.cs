using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlantScreept : MonoBehaviour {
    /*// Изменение скорости перемещения героя
    public float playerSpeed = 20.0f;

    // Текущая скорость перемещения
    private float currentSpeed = 0.0f;

    // Создание переменных для кнопок
    public List<KeyCode> leftButton;
    public List<KeyCode> rightButton;

    // Сохранение последнего перемещения
    private Vector3 lastMovement = new Vector3();

    // Update is called once per frame
    void Update()
    {
        // Перемещение героя
        Movement();
    }

   
    // Движение героя к мышке
    void Movement() { 
   // Необходимое движение
    Vector3 movement = new Vector3();
    Vector3 oo = new Vector3(0, -1, 0);
    // Проверка нажатых клавишь
    movement += MoveIfPressed(leftButton, Vector3.up);
    movement += MoveIfPressed(rightButton, oo);
    // Если нажато несколько кнопок, обрабатываем это
    movement.Normalize();
		// Проверка нажатия кнопки
		if(movement.magnitude > 0)
		{
			// После нажатия двигаемся в этом направлении
			currentSpeed = playerSpeed;
			this.transform.RotateAround(movement, Vector3.forward, 20 * Time.deltaTime);
            lastMovement = movement;
		}
		else
		{
            // Если ничего не нажато
           // this.transform.Translate(lastMovement* Time.deltaTime* currentSpeed, Space.World);
// Замедление со временем
currentSpeed *= 0.9f;
}
	}

    // Возвращает движение, если нажата кнопка
    Vector3 MoveIfPressed(List<KeyCode> keyList, Vector3 Movement)
    {
        // Проверяем кнопки из списка
        foreach (KeyCode element in keyList)
        {
            if (Input.GetKey(element))
            {
                // Если нажато, покидаем функцию
                return Movement;
            }
        }
        // Если кнопки не нажаты, то не двигаемся
        return Vector3.zero;
    }
    */
    public float angle=45f;
    private float currentAngle = 0.0f;
    void Start()
    {
    }
    void Update()
    {
     if((Input.GetKey(KeyCode.A))|| (Input.GetKey(KeyCode.LeftArrow)))
        {
            currentAngle += (Time.deltaTime * 30f) ;
            gameObject.transform.eulerAngles = new Vector3(0, 0, currentAngle);
        }

        if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
        {
            currentAngle -= (Time.deltaTime * 30f);
            gameObject.transform.eulerAngles = new Vector3(0, 0, currentAngle);
        }
    }
}
