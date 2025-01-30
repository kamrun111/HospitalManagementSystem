using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using HIMS.DAL;

using HIMS.BusinessObjects;
using System.Windows.Forms;


namespace NewHIMS
{
    public class CommonClass
    {
        public void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            try
            {
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;
                combo.DataSource = ds.Tables[tableIndex];
                combo.SelectedIndex = -1;
                combo.Text = "<Select>";
            }
            catch
            {
            }

        }
        public void NumCheck(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        public void FillUpListview(ListView lvw, DataSet ds, int tableIndex)
        {
            lvw.Items.Clear();

            for (int i = 0; i < ds.Tables[tableIndex].Rows.Count; i++)
            {
                DataRow dataRow = ds.Tables[tableIndex].Rows[i];

                if (dataRow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(dataRow[0].ToString());
                    for (int j = 1; j < lvw.Columns.Count; j++)
                    {
                        lvi.SubItems.Add(dataRow[j].ToString());
                    }
                    lvw.Items.Add(lvi);
                }
            }
        }
        public DataSet GetDataSet(string procName)
        {
            try
            {

                return DbHelper.GetDataSet(CommandType.StoredProcedure, procName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetDataSetWithParameter(string paramer, int id, string procName)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter(paramer, id);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, procName, arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetDataSetWithDateParameter(string paramer, DateTime date, string procName)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter(paramer, date);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, procName, arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet GetDataSetWithStringParameter(string paramer, string value, string procName)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter(paramer, value);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, procName, arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetDataSetWithTwoDateParameter(string paramer1, string paramer2, DateTime From, DateTime To, string procName)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter(paramer1, From);
                arParams[1] = new SqlParameter(paramer2, To);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, procName, arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetDataSetWithTwoIntParameter(string paramer1, string paramer2, int From, int To, string procName)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter(paramer1, From);
                arParams[1] = new SqlParameter(paramer2, To);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, procName, arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        internal void FillUpListview(ListView lvwList, DataTable dt, int p)
        {
            throw new NotImplementedException();
        }

        public DataSet GetDataSetWithOneStringOneIntParameter(string paramer1, string paramer2, string value1, int value2, string procName)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter(paramer1, value1);
                arParams[1] = new SqlParameter(paramer2, value2);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, procName, arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
    }
}
