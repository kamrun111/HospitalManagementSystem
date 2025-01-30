using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using System.Reflection;
using NewHIMS.Forms.Nurse_Station.Nurse_Indent;

namespace NewHIMS.Forms.ReqisitionHIMS
{
    public partial class frmtest : Form
    {
        Assembly _assembly;
        ArrayList classlist;
        public frmtest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "DLL files (*.dll)|*.dll";
            if (openFileDialog1.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }
            txtDLL.Text = openFileDialog1.SafeFileName;
            string filename = openFileDialog1.FileName.ToString();
            _assembly = Assembly.LoadFile(filename);
            classlist = new ArrayList();
            foreach (Type oType in _assembly.GetTypes())
            {

                //Type tt = _assembly.GetTypes();
                if (oType.IsClass)
                {
                    //if (oType.BaseType.FullName == "ICS.Core.Framework.BusinessObject")
                    //{
                        classlist.Add(oType);
                    //}
                }
            }
            dgvClassName.Rows.Clear();
            for (int i = 0; i < classlist.Count-1; i++)
            {
                dgvClassName.Rows.Add();
                dgvClassName.Rows[i].Cells[1].Value = classlist[i];
            }
        }

        private void dgvClassName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvClassName.SelectedRows[0].Index > 0)
            //{
            object obb = classlist[this.dgvClassName.SelectedRows[0].Index];



            
            
            foreach (Type oType in _assembly.GetTypes())
            {
                if (oType.IsClass)
                {
                     object ClassObj = Activator.CreateInstance(oType);
                     Type t = ClassObj.GetType();
                     PropertyInfo[] pi = t.GetProperties();
                     foreach (PropertyInfo prop in pi)
                     {
                     }
                    //if (oType.FullName == this.dgvClassName.SelectedRows[0].Cells[1].Value.ToString())
                    //{
                        
                    //}
                }
               

            
            }
            }

        }
    }

