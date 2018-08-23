using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyControls.Model;

namespace MyControls
{
    public partial class LoopSearch : UserControl , IDefault
    {
       
        private DataTable dt;
        private DbHandler dbHandler;
        private DefaultUcProp _defaultUcProp;
        public event EventHandler TxtChanged;

        public LoopSearch()
        {
            InitializeComponent();
        }

        [Category("MyCustom")]
        public DefaultUcProp UserControlProp
        {
            get { return _defaultUcProp; }
            set { _defaultUcProp = value; }
        }

       
        private void StdSearch_Load(object sender, EventArgs e)
        {
            if (DesignMode == false) { }
        }

        private void fillData()
        {
            try
            {
                dt = dbHandler.FillMyDt(_defaultUcProp.SearchQuery);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void txtCode_Validating(object sender, CancelEventArgs e)
        {
            String strsql;
            try
            {
                if (!txtCode.Text.Trim().Equals(""))
                {

                    strsql = "select " + _defaultUcProp.DescField + " from " + _defaultUcProp.TableName + " ";
                    strsql += " where " + _defaultUcProp.CodeField + " ='" + txtCode.Text.Trim().Replace("'","''") + "'";

                    string retval = dbHandler.ExecuteScalar(strsql);

                    if (retval == null)
                    {
                        MessageBox.Show("Invalid Studrnt Code", FindForm().Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }else
                    {
                        lblDesc.Text = retval;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
          
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            lblDesc.Text = "";
            OnTextChanged(sender);
        }

        public void OnTextChanged(object sender)
        {
            if (TxtChanged == null)
                return;
            TxtChanged(sender, new EventArgs());
        }

        public void clearLoop()
        {
            txtCode.Text = "";
            lblDesc.Text = "";
        }

        public String getCodeValue()
        {
            return txtCode.Text.Trim();
        }

        public void InitUc()
        {
            dbHandler = DbHandler.getInstance(_defaultUcProp.ConnectionString);
        }
    }
}
