using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab10
{
    public partial class RegistryModelingForm : Form
    {
        private const string Filename = "regedit2.bin";

        public RegistryModelingForm()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = false;
        }

        private void RegistryModelingForm_Load(object sender, EventArgs e)
        {
            LoadAndSave.LoadTree(treeView1, Filename);
            //treeView1.Nodes.Add("Root");
            treeView1.ExpandAll();
        }

        private void RegistryModelingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadAndSave.SaveTree(treeView1, Filename);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label2.Text = treeView1.SelectedNode.Tag != null ? treeView1.SelectedNode.FullPath : "";
            dataGridView1.Visible = treeView1.SelectedNode.Tag != null;


            if (treeView1.SelectedNode.Tag != null)
                ShowLeaves();
        }

        private void ShowLeaves()
        {
            dataGridView1.Rows.Clear();

            foreach (Leaf leaf in (List<Leaf>) treeView1.SelectedNode.Tag)
            {
                dataGridView1.Rows.Add(leaf.Name, leaf.Type, leaf.Key);
            }
        }

        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Delete))
            {
                ((TreeView) sender).SelectedNode.Remove();
            }

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            new TextBoxInputForm(e.Node).ShowDialog();

            treeView1.ExpandAll();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right))
            {
                treeView1.SelectedNode.Tag = new List<Leaf>();
                label2.Text = treeView1.SelectedNode.FullPath;
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].ErrorText = "";

            if (dataGridView1.Rows[e.RowIndex].IsNewRow) { return; }
            if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
            {
                e.Cancel = true;
                dataGridView1.Rows[e.RowIndex].ErrorText = "the value must be not null or whitespaces";
            }


        }

        private string _beginEditCell;

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string currentText = dataGridView1.CurrentCell.EditedFormattedValue.ToString().Trim();

            dataGridView1.CurrentCell.Value = string.IsNullOrWhiteSpace(currentText.ToLower())
                ? _beginEditCell
                : currentText;

            try
            {
                if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
                    ((List<Leaf>)treeView1.SelectedNode.Tag)[e.RowIndex] =
                        new Leaf(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()
                            , dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                            dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _beginEditCell = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            if (dataGridView1.CurrentCell.Value != null)
            {
                _beginEditCell = dataGridView1.CurrentCell.Value.ToString().Trim();
            }
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            //for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //{
            //    e.Row.Cells[0].Value = "1";
            //    e.Row.Cells[1].Value = "2";
            //    e.Row.Cells[2].Value = "3";
            //}
            ((List<Leaf>)treeView1.SelectedNode.Tag).Add(new Leaf("1", "2", "3"));
            dataGridView1.Rows.Add("1", "2", "3");
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Delete))
            {
                if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
                {
                    ((DataGridView)sender).Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    ((List<Leaf>)treeView1.SelectedNode.Tag).RemoveAt(dataGridView1.CurrentRow.Index);
                }  
            }
        }

    }

}

