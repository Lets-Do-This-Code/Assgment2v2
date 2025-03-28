using UnityEngine;
using UnityEngine.UI;

public class ButtonFunctions : MonoBehaviour
{
    public GameObject person;
    public Button growButton, shrinkButton, spinLeftButton, spinRightButton, moveLeftButton, moveRightButton, resetButton;
    public float scaleAmount = 1.2f;
    public float rotationAmount = 20f;
    public float moveDistance = 1f;

    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private Vector3 originalScale;

    void Start()
    {
        if (person == null) return;

        originalPosition = person.transform.position;
        originalRotation = person.transform.rotation;
        originalScale = person.transform.localScale;

        if (growButton != null) growButton.onClick.AddListener(Grow);
        if (shrinkButton != null) shrinkButton.onClick.AddListener(Shrink);
        if (spinLeftButton != null) spinLeftButton.onClick.AddListener(SpinLeft);
        if (spinRightButton != null) spinRightButton.onClick.AddListener(SpinRight);
        if (moveLeftButton != null) moveLeftButton.onClick.AddListener(MoveLeft);
        if (moveRightButton != null) moveRightButton.onClick.AddListener(MoveRight);
        if (resetButton != null) resetButton.onClick.AddListener(ResetPerson);
    }

    public void Grow()
    {
        person.transform.localScale *= scaleAmount;
    }

    public void Shrink()
    {
        person.transform.localScale /= scaleAmount;
    }

    public void SpinLeft()
    {
        person.transform.Rotate(Vector3.up, -rotationAmount);
    }

    public void SpinRight()
    {
        person.transform.Rotate(Vector3.up, rotationAmount);
    }

    public void MoveLeft()
    {
        person.transform.position += Vector3.left * moveDistance;
    }

    public void MoveRight()
    {
        person.transform.position += Vector3.right * moveDistance;
    }

    public void ResetPerson()
    {
        person.transform.position = originalPosition;
        person.transform.rotation = originalRotation;
        person.transform.localScale = originalScale;
    }
}
