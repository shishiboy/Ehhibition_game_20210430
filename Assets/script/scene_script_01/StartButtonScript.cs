using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class StartButtonScript : MonoBehaviour
{

    public void OnClickStartButton()
    {
        SceneManager.LoadScene("ver2_0609");
    }
}