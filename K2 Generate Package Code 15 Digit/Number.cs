using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K2_Generate_Package_Code_15_Digit
{
    public partial class Number : Form
    {
        public Number()
        {
            InitializeComponent();
        }
        public List<DAL.IntDecimal> IntDecimalGlobal;
        public List<DAL.AnotherDecimal> AnotherDecimalGlobal;
        public string No1;
        public string Code1;
        public string No2;
        public string Code2;
        public string No3;
        public string Code3;
        public string Status;
        public string pkgGroup;
        private void textBoxNum1_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";

            var fInt = from x in IntDecimalGlobal select new { No = x.No, Code = x.Code };
            dataGridView1.DataSource = fInt.ToList();
            Status = "num1";
        }

        private void textBoxNum2_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            if (pkgGroup == "Normal")
            {
                var fInt = from x in IntDecimalGlobal where x.id < 11 select new { No = x.No, Code = x.Code };
                dataGridView1.DataSource = fInt.ToList();
                Status = "num2";
            }
            else
            {
                var fInt = from x in AnotherDecimalGlobal  select new { No = x.No, Code = x.Code };
                dataGridView1.DataSource = fInt.ToList();
                Status = "num2";
            }
        }

        private void Number_Load(object sender, EventArgs e)
        {
            var fInt = from x in IntDecimalGlobal select new { No = x.No, Code = x.Code };
            dataGridView1.DataSource = fInt.ToList();
            //DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            //editButtonColumn.Name = "Action";
            //editButtonColumn.Text = "Action";
            Status = "num1";
            //if (dataGridView1.Columns["Action"] == null)
            //{
            //    dataGridView1.Columns.Insert(0, editButtonColumn);
            //}
            //this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //if (e.RowIndex < 0)
            //    return;
            //if (e.ColumnIndex == 0)
            //{
            //    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            //    Image someImage = Properties.Resources.accept;

            //    var w = Properties.Resources.accept.Width;
            //    var h = Properties.Resources.accept.Height;
            //    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
            //    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
            //    e.Graphics.DrawImage(someImage, new Rectangle(x, y, w, h));
            //    e.Handled = true;
            //}
        }

        private void textBoxNum3_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";

            if (pkgGroup == "Normal")
            {
                var fInt = from x in IntDecimalGlobal where x.id < 11 select new { No = x.No, Code = x.Code };
                dataGridView1.DataSource = fInt.ToList();
                Status = "num3";
            }
            else
            {
                var fInt = from x in AnotherDecimalGlobal select new { No = x.No, Code = x.Code };
                dataGridView1.DataSource = fInt.ToList();
                Status = "num3";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (Status)
                {
                    case "num1":
                        No1 = (dataGridView1.Rows[e.RowIndex].Cells["No"].Value != null) ? dataGridView1.Rows[e.RowIndex].Cells["No"].Value.ToString() : "null";
                        Code1 = dataGridView1.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        textBoxNum1.Text = No1;
                        labelShown.Text = Code1 + Code2 + Code3;
                        break;
                    case "num2":
                        if (pkgGroup != "Normal")
                        {
                            No2 = (dataGridView1.Rows[e.RowIndex].Cells["No"].Value != null) ? dataGridView1.Rows[e.RowIndex].Cells["No"].Value.ToString() : "null";
                            Code2 = dataGridView1.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                            char c1 = No2[0];
                            char c2 = No2[1];
                            textBoxNum2.Text = c1.ToString();
                            textBoxNum3.Text = c2.ToString();
                            labelShown.Text = Code1 + Code2 + Code3;
                        }
                        else
                        {
                            No2 = (dataGridView1.Rows[e.RowIndex].Cells["No"].Value != null) ? dataGridView1.Rows[e.RowIndex].Cells["No"].Value.ToString() : "null";
                            Code2 = dataGridView1.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                            textBoxNum2.Text = No2;
                            labelShown.Text = Code1 + Code2 + Code3;

                        }
                        break;
                    case "num3":
                        if (pkgGroup == "Normal")
                        {
                            No3 = (dataGridView1.Rows[e.RowIndex].Cells["No"].Value != null) ? dataGridView1.Rows[e.RowIndex].Cells["No"].Value.ToString() : "null";
                            Code3 = dataGridView1.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                            textBoxNum3.Text = No3;
                            labelShown.Text = Code1 + Code2 + Code3;
                        }
                        else
                        {
                            No2 = (dataGridView1.Rows[e.RowIndex].Cells["No"].Value != null) ? dataGridView1.Rows[e.RowIndex].Cells["No"].Value.ToString() : "null";
                            Code2 = dataGridView1.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                            char c1 = No2[0];
                            char c2 = No2[1];
                            textBoxNum2.Text = c1.ToString();
                            textBoxNum3.Text = c2.ToString();
                            labelShown.Text = Code1 + Code2 + Code3;
                        }
                        break;
                }
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Code ที่กำหนดคือ " + Code1+Code2+Code3 + "\nหรือ No = " + No1 + "." + No2 + No3+ "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
            if (dR == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != null)
            {
                switch (Status)
                {
                    case "num1":

                        var ppPkgH = from x in IntDecimalGlobal where x.Code.Contains(textBoxSearch.Text.ToUpper())|| x.No.Contains(textBoxSearch.Text) select new { No = x.No, Code = x.Code };
                        if (ppPkgH != null)
                        {
                            dataGridView1.DataSource = ppPkgH.ToList();

                        }

                        break;
                    case "num2":
                        if (pkgGroup == "Normal")
                        {
                            var PkgType = from x in IntDecimalGlobal where x.id < 11 && (x.Code.Contains(textBoxSearch.Text.ToUpper()) || x.No.Contains(textBoxSearch.Text)) select new { No = x.No, Code = x.Code };
                            if (PkgType != null)
                            {
                                dataGridView1.DataSource = PkgType.ToList();

                            }
                        }
                        else
                        {
                            var PkgType = from x in AnotherDecimalGlobal where  x.Code.Contains(textBoxSearch.Text.ToUpper()) || x.No.Contains(textBoxSearch.Text) select new { No = x.No, Code = x.Code };
                            if (PkgType != null)
                            {
                                dataGridView1.DataSource = PkgType.ToList();

                            }
                        }
                        break;
                    case "num3":
                        var PkgSp = from x in IntDecimalGlobal where x.id < 11 && (x.Code.Contains(textBoxSearch.Text.ToUpper()) || x.No.Contains(textBoxSearch.Text)) select new { No = x.No, Code = x.Code };
                        if (PkgSp != null)
                        {
                            dataGridView1.DataSource = PkgSp.ToList();

                        }
                        else
                        {
                            var PkgSpp = from x in AnotherDecimalGlobal where x.Code.Contains(textBoxSearch.Text.ToUpper()) || x.No.Contains(textBoxSearch.Text) select new { No = x.No, Code = x.Code };
                            if (PkgSpp != null)
                            {
                                dataGridView1.DataSource = PkgSpp.ToList();

                            }
                        }
                        break;
                }

            }
        }
    }
}
