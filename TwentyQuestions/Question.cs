using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyQuestions
{
    class Question
    {
        public string QuestionLabel { get; set; }
        public Question Yes { get; set; }
        public Question No { get; set; }

        public bool IsLeaf() {
            return Yes == null && No == null;
        }
    }
}
