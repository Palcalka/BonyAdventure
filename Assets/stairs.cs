using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public float climbSpeed = 5f; // Скорость подъёма по лестнице
    private bool isClimbing = false; // Флаг, указывает, находится ли игрок на лестнице
    private Rigidbody2D playerRigidbody; // Rigidbody игрока

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Проверяем, есть ли у объекта тег Player
        if (collision.CompareTag("Player"))
        {
            playerRigidbody = collision.GetComponent<Rigidbody2D>();
            if (playerRigidbody != null)
            {
                playerRigidbody.gravityScale = 0; // Отключаем гравитацию
                isClimbing = true; // Включаем флаг подъёма
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Если игрок покидает лестницу
        if (collision.CompareTag("Player"))
        {
            if (playerRigidbody != null)
            {
                playerRigidbody.gravityScale = 1; // Включаем гравитацию обратно
                isClimbing = false; // Отключаем флаг подъёма
            }
        }
    }

    private void Update()
    {
        if (isClimbing && playerRigidbody != null)
        {
            float verticalInput = Input.GetAxis("Vertical"); // Получаем ввод по вертикальной оси (W/S или стрелки)
            playerRigidbody.velocity = new Vector2(playerRigidbody.velocity.x, verticalInput * climbSpeed);
        }
    }
}
