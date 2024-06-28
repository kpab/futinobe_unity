using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainEvent : MonoBehaviour
{
    // futinobe03シーンへ^_^
    public void GoFuti03()
    {
        SceneManager.LoadScene("futinobe01");
    }
    public void GoMain()
    {
        SceneManager.LoadScene("Main");
    }
    public void Gofuti04()
    {
        SceneManager.LoadScene("futinobe04");
    }
    public void Gofuti04_2()
    {
        SceneManager.LoadScene("futinobe04_2");
    }
    public void Gofuti05()
    {
        SceneManager.LoadScene("futinobe05");
    }
    public void Gofuti05_2()
    {
        SceneManager.LoadScene("futinobe05_2");
    }
    public void Gofuti05_3()
    {
        SceneManager.LoadScene("futinobe05_3");
    }
}