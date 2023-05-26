using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DynamicControls
{
    public partial class Form1 : Form
    {
        private readonly object controlTypeComboBox;
        private readonly object controlsPanel;
        private readonly object controlTextTextBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Create a new control based on the selected type
            Control newControl;
            switch (controlTypeComboBox.SelectedItem.ToString())
            {
                case "Button":
                    newControl = new Button();
                    break;
                case "Label":
                    newControl = new Label();
                    break;
                case "TextBox":
                    newControl = new TextBox();
                    break;
                default:
                    MessageBox.Show("Please select a control type.");
                    return;
            }

            // Set the control's properties
            newControl.Location = new Point(10, 10 + controlsPanel.Controls.Count * 30);
            newControl.Text = controlTextTextBox.Text;

            // Add the control to the panel
            controlsPanel.Controls.Add(newControl);
        }
    }
}
