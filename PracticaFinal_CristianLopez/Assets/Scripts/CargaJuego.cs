using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargaJuego : MonoBehaviour
{
    public void GameScene()
    {
        SceneManager.LoadScene("Juego");
    }
}
