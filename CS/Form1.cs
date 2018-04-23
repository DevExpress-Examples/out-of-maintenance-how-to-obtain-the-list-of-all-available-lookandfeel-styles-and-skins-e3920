using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.Controls;
using DevExpress.Skins;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) });
            return tbl;
        }

        public Form1()
        {
            InitializeComponent();
            gridControl1.DataSource = CreateTable(20);
            foreach (var item in Enum.GetValues(typeof(LookAndFeelStyle)))
            {
                rgStyles.Properties.Items.Add(new RadioGroupItem(item, item.ToString()));
            }
            foreach (SkinContainer item in SkinManager.Default.Skins)
            {
                rgSkins.Properties.Items.Add(new RadioGroupItem(item.SkinName, item.SkinName));
            }
        }

        private void rgStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.Style = (LookAndFeelStyle)rgStyles.EditValue;
        }

        private void rgSkins_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SkinName = rgSkins.EditValue.ToString();
            rgStyles.EditValue = LookAndFeelStyle.Skin;
            
        }

        
    }
}
