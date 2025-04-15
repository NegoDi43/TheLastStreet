using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Jogar()
    {
        SceneManager.LoadScene("selecionaPersonagens");
    }
    private void OnMouseDown()
    {

    }
    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }
    public void MenuPricipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
    public void ricardo()
    {
        SceneManager.LoadScene("ricardo");
    }
    public void jorel()
    {
        SceneManager.LoadScene("jorel");
    }
    public void leandro()
    {
        SceneManager.LoadScene("leandro");
    }
}
