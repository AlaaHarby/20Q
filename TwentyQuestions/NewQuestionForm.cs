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
    public partial class NewQuestionForm : Form
    {
        TreeNavigator navigator;
        public NewQuestionForm()
        {
            InitializeComponent();
            navigator = TreeNavigator.Instance;
        }

        private void play_again_Click(object sender, EventArgs e)
        {
            setResults(DialogResult.Yes);
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            setResults(DialogResult.Abort);
        }

        void setResults(DialogResult result) {
            navigator.UpdateTree(question_text.Text, answer_text.Text);
            this.DialogResult = result;
            Close();
        }
    }
}
