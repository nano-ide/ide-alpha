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
    public partial class frmSettingLite : Form
    {
        public frmSettingLite()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 設定の中止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // TODO: 選択フォルダが変更されている場合は確認する
            if (true)
            {
                if (MessageBox.Show("変更をキャンセルしますか？", "確認", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    return;
            }
            this.Close();
        }

        /// <summary>
        /// 開発ツールをインストールするフォルダの選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFolder1_Click(object sender, EventArgs e)
        {
            //
        }

        /// <summary>
        /// プロジェクトを作成するフォルダの選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFolder2_Click(object sender, EventArgs e)
        {
            //
        }

        /// <summary>
        /// バックアップデータを保存するフォルダの選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFolder3_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
