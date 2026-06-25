using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioController : MonoBehaviour
{
    // Inicia o jogo carregando a fase 1
    public void NovoJogo()
    {
        SceneManager.LoadScene("fase1");
    }

    // Fecha o jogo
    public void SairJogo()
    {
        Debug.Log("Saindo do jogo...");

        Application.Quit();

        // Funciona apenas dentro da Unity
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}