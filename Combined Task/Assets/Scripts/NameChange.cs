using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NameChange : MonoBehaviour
{
    public TMP_InputField inputField; // Reference to the input field
    public TextMeshProUGUI displayText; // Reference to the text component to update
    public Button changeTextButton; // Reference to the button

    void Start()
    {
        // Ensure the button triggers the text change
        changeTextButton.onClick.AddListener(ChangeText);
    }

    void ChangeText()
    {
        // Get the text from the input field and update the display text
        if (inputField != null && displayText != null)
        {
            displayText.text = inputField.text;
        }
        else
        {
            Debug.LogError("Input Field or Display Text is not assigned.");
        }
    }
}
