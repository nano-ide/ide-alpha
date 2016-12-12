using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NanoIDE
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region メインメニューアイテム
        
        /// <summary>
        /// フォルダ設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miFolderSetting_Click(object sender, EventArgs e)
        {
            using (frmSettingLite frm = new frmSettingLite())
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;
            }
        }


        #endregion

    }
}
