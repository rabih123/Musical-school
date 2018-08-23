using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyControls.Model
{
        [ComVisible(true), TypeConverter(typeof(DefaultUcPropConverter))]
    public class DefaultUcProp
    {
        [Category("Custom"), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Localizable(true)]
        public string CodeField { get; set; }
        [Category("Custom"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DescField { get; set; }
        public string SearchQuery { get; set; }
        public string ConnectionString { get; set; }
        public string TableName { get; set; }

    }
}
