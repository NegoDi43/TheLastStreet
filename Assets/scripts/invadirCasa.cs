using UnityEngine;
using UnityEngine.SceneManagement;

public class invadirCasa : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InvadirMoradia()
    {
        SceneManager.LoadScene("invadirMoradia");
    }
}
