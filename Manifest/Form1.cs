using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manifest
{
    public partial class Form1 : Form
    {
        private int gridRows = 0;
        private string path = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updatedValuesGrid.ColumnCount = 3;
            updatedValuesGrid.Columns[0].HeaderText = "Max duration";
            updatedValuesGrid.Columns[1].HeaderText = "Max mark";
            updatedValuesGrid.Columns[2].HeaderText = "Pass mark";
            updatedValuesGrid.RowHeadersWidth = 50;

            gridUpdate();
            directoryInfo.Text = Export.loadPath();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Export.exportData(gridToArray());
            directoryInfo.Text = Export.GetPath();

        }

        private void maxDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void maxMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void passMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void scenCount_ValueChanged(object sender, EventArgs e)
        {
            gridUpdate();
        }

        private void defaultMaxDurationApply_Click(object sender, EventArgs e)
        {
            gridColumnUpdate(0, maxDuration.Text.Trim());
        }

        private void defaultMaxMarkApply_Click(object sender, EventArgs e)
        {
            gridColumnUpdate(1, maxMark.Text.Trim());

        }

        private void defaultPassMarkApply_Click(object sender, EventArgs e)
        {
            gridColumnUpdate(2, passMark.Text.Trim());

        }
        private void browseDirectory_Click(object sender, EventArgs e)
        {
            Export.selectPath(true);
            directoryInfo.Text = Export.GetPath();
        }

        private string[,] gridToArray() 
        {
            string[,] dataArray = new string[updatedValuesGrid.RowCount, updatedValuesGrid.ColumnCount];
            for(int i = 0;i < updatedValuesGrid.ColumnCount; i++) 
            {
                for(int j = 0; j < updatedValuesGrid.RowCount; j++) 
                {
                    dataArray[j, i] = updatedValuesGrid[i, j].Value.ToString().Trim();
                }
            }
            return dataArray;
        } 

        private void gridColumnUpdate(int column, string value) 
        {
            for (int i = 0; i < updatedValuesGrid.RowCount; i++)
            {
                updatedValuesGrid[column, i].Value = value;
            }
        }

        private void gridUpdate()
        {
            updatedValuesGrid.RowCount = (int)scenCount.Value + 1;

            if (updatedValuesGrid.RowCount > gridRows)
            {
                int lastRowIndex = updatedValuesGrid.RowCount - 1;
                updatedValuesGrid[0, lastRowIndex].Value = maxDuration.Text.Trim();
                updatedValuesGrid[1, lastRowIndex].Value = maxMark.Text.Trim();
                updatedValuesGrid[2, lastRowIndex].Value = passMark.Text.Trim();

            }

            gridRows = updatedValuesGrid.RowCount;

            for (int i = 0; i < updatedValuesGrid.Rows.Count; i++)
            {
                DataGridViewRowHeaderCell cell = updatedValuesGrid.Rows[i].HeaderCell;
                cell.Value = "S"+(i + 1).ToString();
                updatedValuesGrid.Rows[i].HeaderCell = cell;
            }
        }


    }
}
