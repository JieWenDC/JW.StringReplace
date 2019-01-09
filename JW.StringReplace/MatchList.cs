using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JW.StringReplace
{
    public partial class MatchList : Form
    {
        public MatchList(List<string> data)
        {
            InitializeComponent();
            this.dgv_lists.DataSource = (from item in data
                                         orderby item
                                         select new { Path = item })
                                        .ToList();
        }
    }
}
