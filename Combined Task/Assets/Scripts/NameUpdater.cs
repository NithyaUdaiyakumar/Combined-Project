using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameUpdater : MonoBehaviour
{
    public TMP_InputField nameInputField;  // Input field to type the new name
    public TMP_Text nameDisplayText;       // Text to display the updated name
    public Button changeNameButton;        // Button to trigger the name change
    public GameObject[] objects;           // Array of objects to update names
    public TMP_Dropdown objectDropdown;    // Dropdown to select the object to rename

    private void Start()
    {
        // Populate the dropdown with object names
        PopulateDropdown();

        // Add listener to the button
        changeNameButton.onClick.AddListener(UpdateObjectName);
    }

    void PopulateDropdown()
    {
        objectDropdown.options.Clear();

        // Add each object's name to the dropdown
        foreach (GameObject obj in objects)
        {
            objectDropdown.options.Add(new TMP_Dropdown.OptionData(obj.name));
        }

        objectDropdown.RefreshShownValue();
    }

    void UpdateObjectName()
    {
        string newName = nameInputField.text;

        if (!string.IsNullOrWhiteSpace(newName))
        {
            // Get the selected object index from the dropdown
            int selectedIndex = objectDropdown.value;

            // Update the selected object's name
            GameObject selectedObject = objects[selectedIndex];
            selectedObject.name = newName;

            // Update the display text to show the new name
            nameDisplayText.text = $"Updated Name: {newName}";

            // Update the dropdown to reflect the new name
            objectDropdown.options[selectedIndex].text = newName;
            objectDropdown.RefreshShownValue();
        }
        else
        {
            Debug.LogWarning("Name input field is empty. Please enter a valid name.");
        }
    }
}
