namespace VolumeConverter
{
    public partial class volumeConverter : Form
    {
        public volumeConverter()
        {
            InitializeComponent();
            litreTextBox.Enabled = false;
        }

       


        private void cancelButton_Click(object sender, EventArgs e)
        {
            clTextBox.Text = "";
            litreTextBox.Text = "";
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            float cl;
            float litre;
            cl = Convert.ToInt32(clTextBox.Text);
            litre = cl / 100;
            litreTextBox.Text = litre.ToString();
        }

        private void clLabel_Click(object sender, EventArgs e)
        {

        }

        private void clTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


//NameSpaces
// designed for providing a way to keep one set of names seprate from another. They contain a set of related objects.

//Public
// Indicates the method (functions) can be accessed inside and outside of the class.

//Private
//Indicates the method (function) can be accesses only inside this class.

//Void
//Indicates the method is not expected to return any value

//Partial
// Indicates that other parts of the class, or interface can be defined in the namespace.

//Class
// is a blueprint (template) for creating objects.

//InitializeComponent
// is a method (function) of windows forms designer and it defines everything you see on the form.


//Object Sender
// is a parameter called sender that contains a reference to the control/object that raised the event.