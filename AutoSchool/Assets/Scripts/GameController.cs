using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int whatCar;
    private bool[] goTrue;
    public Animator[] anims;
   
    public void ChooseCar(int choose)
    {
        whatCar = choose;
        if (whatCar == 1)
        {
            anims[0].SetBool("R", true);
            anims[1].SetBool("R", true);
            Invoke("Restart", 2f);
        }
        if (whatCar == 2)
        {
            anims[1].SetBool("Go", true);
            Invoke("LastGo", 1.5f);
            Invoke("Restart", 5f);
        }
    }
    private void LastGo()
    {
        anims[0].SetBool("Go", true);
    }
    private void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
