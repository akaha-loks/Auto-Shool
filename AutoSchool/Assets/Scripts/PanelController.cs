using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    public GameObject panel; // ссылка на панель, которую вы хотите отобразить/скрыть

    void Start()
    {
        // Начинаем с скрытой панели
        panel.SetActive(false);
    }

    public void TogglePanel()
    {
        // Меняем видимость панели на противоположную
        panel.SetActive(!panel.activeSelf);
    }
}