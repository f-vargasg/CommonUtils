﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonUtils.DataGrid
{
    public class DataGridTools
    {

        public DataGridView DgrdView { get; set; }

        public string FontName { get; set; }
        public float FontSize { get; set; }

        public DataGridTools() 
        {
            this.FontName = "Arial";
            this.FontSize = 14f;
        }

        public DataGridTools(DataGridView pDgrdV)
        {
            this.FontName = "Arial";
            this.FontSize = 14f;
            DgrdView = pDgrdV;
        }

        public void HideColumns(string colToHide)
        {
            string[] strings = colToHide.Split(',');
            foreach (var colStr in strings)
            {
                int ind = Convert.ToInt32(colStr);
                this.DgrdView.Columns[ind].Visible = false;
            }
        }
        public void FillDataGrid<T>(List<T> list)
        {
            var bindingList = new BindingList<T>(list);
            var source = new BindingSource(bindingList, null);
            this.DgrdView.DataSource = source;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">Tipo</typeparam>
        /// <param name="list">Lista de tipo</param>
        /// <param name="plstColsToHide">Columnas a esconder del grid</param>
        public void FillDataGrid<T>(List<T> list,
                                    string plstColsToHide)
        {
            var bindingList = new BindingList<T>(list);
            var source = new BindingSource(bindingList, null);
            this.DgrdView.DataSource = source;
            HideColumns(plstColsToHide);
        }

        public void AdjustColums()
        {
            for (int i = 0; i < this.DgrdView.Columns.Count; i++)
            {
                if (i == this.DgrdView.Columns.Count)
                {
                    this.DgrdView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    this.DgrdView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            for (int i = 0; i < this.DgrdView.Columns.Count; i++)
            {
                int colw = this.DgrdView.Columns[i].Width;
                this.DgrdView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                this.DgrdView.Columns[i].Width = colw;
            }
        }

        public void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in DgrdView.Columns)
            {
                // c.DefaultCellStyle.Font = new Font("Arial", 24F, GraphicsUnit.Pixel);
                c.DefaultCellStyle.Font = new Font(this.FontName, this.FontSize, GraphicsUnit.Pixel);
            }
        }

    }
}
