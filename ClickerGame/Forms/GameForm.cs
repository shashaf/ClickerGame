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
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            gameTimer.Start();
            UpdateUI();
        }

        private void UpdateUI()
        {
            labelScore.Text = $"Очки: {GameState.Instance.Score}";
            btnUpgrade.Text = $"Улучшить ({GameState.Instance.UpgradeCost})";
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            GameState.Instance.AddClick();
            UpdateUI();
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            if (!GameState.Instance.BuyUpgrade())
                MessageBox.Show("Недостаточно очков!");

            UpdateUI();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            GameState.Instance.AutoClick();
            UpdateUI();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Application.Exit();
        }
    }
}
