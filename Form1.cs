namespace Names
{
    public partial class Names : Form
    {
        public Names()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // The code for this handler is going to add the name specified by the txtName textbox to the lstNames listbox.
        // However, we want there to be two conditions to adding the name: the name provided must not be blank, and the name must not already exist.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text)) { 

                lstNames.Items.Add(txtName.Text);

            }
        }
    }
}



