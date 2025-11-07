using UnityEngine;

public class CutinManager : MonoBehaviour
{
    [SerializeField] private GameObject cutinUI;

    public void PlayCutin(Sprite image)
    {
        cutinUI.SetActive(true);
        var img = cutinUI.GetComponent<UnityEngine.UI.Image>();
        img.sprite = image;

        Animator anim = cutinUI.GetComponent<Animator>();
        anim.Play("CutinEnter");
    }

    public void EndCutin()
    {
        cutinUI.SetActive(false);
    }
}
