using ClickerGame.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            numericClickPower.Value = GameState.Instance.ClickPower;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GameState.Instance.Reset();
            GameState.Instance.GetType()
                .GetProperty("ClickPower")
                .SetValue(GameState.Instance, (int)numericClickPower.Value);

            this.Close();
        }
    }
}
