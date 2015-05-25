using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace lab7
{
    public partial class PageReplacementForm : Form
    {
        private readonly List<Page> _nruPages = new List<Page>();
        private readonly List<Page> _secondChancePages = new List<Page>();

        private static readonly Color NewPageColor = Color.Aqua;

        public PageReplacementForm()
        {
            InitializeComponent();
        }

        private void PageReplacementForm_Load(object sender, EventArgs e)
        {
            FillPages(dataGridView1, _secondChancePages);
            FillPages(dataGridView2, _nruPages);
        }

        private void FillPages(DataGridView dgv, List<Page> pages)
        {
            for (int i = 0; i < 10; i++)
            {
                var buff = new Page(i.ToString());
                pages.Add(buff);
                dgv.Rows.Add(buff.Name, Convert.ToInt32(buff.Reading), Convert.ToInt32(buff.Modifying), buff.Time,
                    buff.ClassType);
            }
            dgv.Width = dgv.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + dgv.RowHeadersWidth;

            dgv.Height = dgv.Rows
                .GetRowsHeight(DataGridViewElementStates.Visible) + dgv.ColumnHeadersHeight;
            dgv.Location = new Point(0, 0);
        }

        ////////////////
        private static readonly Random Getrandom = new Random(DateTime.Now.Millisecond);
        private static readonly object SyncLock = new object();

        private static int GetRandomNumber(int min, int max)
        {
            lock (SyncLock)
            {
                return Getrandom.Next(min, max);
            }
        }

        private static bool BoolConvertor(string buff)
        {
            return buff.Equals("1");
        }

        #region NRU

        private void buttonInsert1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow page in dataGridView1.Rows)
            {
                page.DefaultCellStyle.BackColor = Color.White;
            }


            int min = 10;
            foreach (DataGridViewRow page in dataGridView1.Rows)
            {
                if (int.Parse(page.Cells[4].Value.ToString()) < min)
                    min = int.Parse(page.Cells[4].Value.ToString());
            }

            var randomPagesForRemoving = (from DataGridViewRow row in dataGridView1.Rows
                where int.Parse(row.Cells[4].Value.ToString()).Equals(min)
                select row.Index).ToList();
            var randPage = randomPagesForRemoving[GetRandomNumber(0, randomPagesForRemoving.Count - 1)];

            //Thread.Sleep(2500);
            _nruPages.RemoveAt(randPage);
            dataGridView1.Rows.RemoveAt(randPage);

            var buff = new Page("");
            _nruPages.Insert(randPage, buff);
            dataGridView1.Rows.Insert(randPage, buff.Name, Convert.ToInt32(buff.Reading),
                Convert.ToInt32(buff.Modifying), buff.Time, buff.ClassType);
            dataGridView1.Rows[randPage].DefaultCellStyle.BackColor = NewPageColor;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];
            var buff = new Page
                (row.Cells[0].Value.ToString(),
                    BoolConvertor(row.Cells[1].Value.ToString()),
                    BoolConvertor(row.Cells[2].Value.ToString()),
                    int.Parse(row.Cells[3].Value.ToString()));
            dataGridView1.Rows[row.Index].Cells[4].Value = buff.ClassType;
            _nruPages.RemoveAt(row.Index);
            _nruPages.Insert(row.Index, buff);
        }

        #endregion


        #region Second Chance

        private void buttonInsert2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow page in dataGridView2.Rows)
            {
                page.DefaultCellStyle.BackColor = Color.White;
            }

            int min = 10;
            foreach (DataGridViewRow page in dataGridView2.Rows)
            {
                if (int.Parse(page.Cells[4].Value.ToString()) < min)
                    min = int.Parse(page.Cells[4].Value.ToString());
            }

            var randomPagesForRemoving = (from DataGridViewRow row in dataGridView2.Rows
                                          where int.Parse(row.Cells[4].Value.ToString()).Equals(min)
                                          select row.Index).ToList();
            var randPage = randomPagesForRemoving[GetRandomNumber(0, randomPagesForRemoving.Count - 1)];

            //Thread.Sleep(2500);
            _secondChancePages.RemoveAt(randPage);
            dataGridView2.Rows.RemoveAt(randPage);

            var buff = new Page("");
            _secondChancePages.Insert(randPage, buff);
            dataGridView2.Rows.Insert(randPage, buff.Name, Convert.ToInt32(buff.Reading),
                Convert.ToInt32(buff.Modifying), buff.Time, buff.ClassType);
            dataGridView2.Rows[randPage].DefaultCellStyle.BackColor = NewPageColor;
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView2.Rows[e.RowIndex];
            var buff = new Page
                (row.Cells[0].Value.ToString(),
                    BoolConvertor(row.Cells[1].Value.ToString()),
                    BoolConvertor(row.Cells[2].Value.ToString()),
                    int.Parse(row.Cells[3].Value.ToString()));
            dataGridView2.Rows[row.Index].Cells[4].Value = buff.ClassType;
            _secondChancePages.RemoveAt(row.Index);
            _secondChancePages.Insert(row.Index, buff);
        }

        #endregion
    }
}
