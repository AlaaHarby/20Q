using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwentyQuestions
{
    public partial class branch_form : Form
    {
        TreeNavigator navigator;

        public branch_form()
        {
            InitializeComponent();
            navigator = TreeNavigator.Instance;
            UpdateForm();
        }

        private void yes_button_Click(object sender, EventArgs e)
        {
            Question q = navigator.GetNext(true);
            if (q == null)
            {
                // Found our answer!
                DialogResult result = MessageBox.Show("Yaay! guessed it .. Play again?!",
                    "Twenty Questions", MessageBoxButtons.YesNo);
                UpdateGame(result);
            }
            else
            {
                UpdateForm();
            }
        }

        private void no_button_Click(object sender, EventArgs e)
        {
            Question q = navigator.GetNext(false);
            if (q == null)
            {
                // Don't know the answer
                NewQuestionForm form = new NewQuestionForm();
                DialogResult result = form.ShowDialog();
                UpdateGame(result);
            }
            else
            {
                UpdateForm();
            }
        }

        public void UpdateForm()
        {
            Question quest = navigator.current;
            q_label.Text = quest.QuestionLabel;
        }

        public void UpdateGame(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                navigator.Reset();
                UpdateForm();
            }
            else
            {
                navigator.Save();
                this.Close();
            }
        }
    }
}
