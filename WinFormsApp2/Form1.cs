namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
            MessageBox.Show("You entered: " + userInput, "Message Box");

            string checkBoxStatus = checkBox1.Checked ? "Enabled" : "Disabled";

            string radioSelection = radioButton1.Checked ? "Option 1" :
                                    radioButton2.Checked ? "Option 2" : "None";

            string comboBoxSelection = comboBox1.SelectedItem?.ToString() ?? "No selection";

            int numericValue = (int)numericUpDown1.Value;

            MessageBox.Show($"CheckBox: {checkBoxStatus}\n" +
                            $"RadioButton: {radioSelection}\n" +
                            $"ComboBox: {comboBoxSelection}\n" +
                            $"NumericUpDown: {numericValue}",
                            "Selections");

            DateTime selectedDate = dateTimePicker1.Value;

            DateTime monthCalendarDate = monthCalendar1.SelectionStart;

            string imageInfo = pictureBox1.Image != null ? "Image is loaded." : "No image found.";

            MessageBox.Show($"DateTimePicker Selected Date: {selectedDate.ToShortDateString()}\n" +
                            $"MonthCalendar Selected Date: {monthCalendarDate.ToShortDateString()}\n" +
                            $"{imageInfo}",
                            "Selected Information");

        }

       
    }
}
