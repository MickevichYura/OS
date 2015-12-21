using System.Windows.Forms;

namespace lab10
{
    public partial class TextBoxInputForm : Form
    {
        public TextBoxInputForm()
        {
            InitializeComponent();
        }

        public TextBoxInputForm(TreeNode node)
        {
            InitializeComponent();
            treeNode = node;
        }

        private TreeNode treeNode;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (e.KeyCode.Equals(Keys.Enter) && !string.IsNullOrWhiteSpace(tb.Text))
            {
                treeNode.Nodes.Add(tb.Text);
                Close();
            }

        }

    }
}
