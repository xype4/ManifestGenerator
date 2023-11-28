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
        private int gridCoulums = 0;
        private string path = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updatedValuesGrid.RowCount = 3;
            gridUpdate();
            directoryInfo.Text = Export.GetPath();
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
            gridRowUpdate(0, maxDuration.Text.Trim());
        }

        private void defaultMaxMarkApply_Click(object sender, EventArgs e)
        {
            gridRowUpdate(1, maxMark.Text.Trim());

        }

        private void defaultPassMarkApply_Click(object sender, EventArgs e)
        {
            gridRowUpdate(2, passMark.Text.Trim());

        }
        private void browseDirectory_Click(object sender, EventArgs e)
        {
            Export.selectPath();
            directoryInfo.Text = Export.GetPath();
        }

        private string[,] gridToArray() 
        {
            string[,] dataArray = new string[updatedValuesGrid.ColumnCount, updatedValuesGrid.RowCount];
            for(int i = 0;i < updatedValuesGrid.ColumnCount; i++) 
            {
                for(int j = 0; j < updatedValuesGrid.RowCount; j++) 
                {
                    dataArray[i, j] = updatedValuesGrid[i, j].Value.ToString().Trim();
                }
            }
            return dataArray;
        } 

        private void gridRowUpdate(int row, string value) 
        {
            for (int i = 0; i < updatedValuesGrid.ColumnCount; i++)
            {
                updatedValuesGrid[i,row].Value = value;
            }
        }

        private void gridUpdate()
        {
            updatedValuesGrid.ColumnCount = (int)scenCount.Value + 1;

            if (updatedValuesGrid.ColumnCount > gridCoulums)
            {
                int lastColumnIndex = updatedValuesGrid.ColumnCount - 1;
                updatedValuesGrid[lastColumnIndex, 0].Value = maxDuration.Text.Trim();
                updatedValuesGrid[lastColumnIndex, 1].Value = maxMark.Text.Trim();
                updatedValuesGrid[lastColumnIndex, 2].Value = passMark.Text.Trim();

            }

            gridCoulums = updatedValuesGrid.ColumnCount;

            for (int i = 0; i < updatedValuesGrid.Columns.Count; i++)
            {
                updatedValuesGrid.Columns[i].HeaderText = "Scene " + i;
            }
        }


    }
}
