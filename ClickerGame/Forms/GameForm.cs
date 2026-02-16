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
                ShowMessage("Недостаточно очков!");

            UpdateUI();
        }

        private void ShowMessage(string text)
        {
            messageTimer.Stop();

            labelMessage.Text = text;
            labelMessage.Visible = true;

            messageTimer.Start();
        }

        private void messageTimer_Tick(object sender, EventArgs e)
        {
            labelMessage.Visible = false;
            messageTimer.Stop();
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

        private bool ConfirmExit()
        {
            var result = MessageBox.Show(
                "Вы уверены, что хотите выйти в меню?\nПрогресс будет утерян.",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            return result == DialogResult.Yes;
        }


        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Application.Exit();
            GameState.Instance.Reset();
            UpdateUI();
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ConfirmExit())
                e.Cancel = true;
        }
    }
}
