using Newtonsoft.Json;
using System.IO;

namespace TwentyQuestions
{
    class TreeLoader
    {
        public Question root { get; set; }

        public TreeLoader() {
            LoadTree();
        }

        void LoadTree() {
            root = JsonConvert.DeserializeObject<Question>(File.ReadAllText("vegetables.txt"));
        }

        public void SaveTree(Question tree)
        {
            File.WriteAllText("vegetables.txt", JsonConvert.SerializeObject(tree));
        }
    }

    class TreeNavigator
    {
        private static TreeNavigator navigator = null;

        Question root;
        Question parent;

        TreeLoader loader;

        public Question current { get; set; }

        private TreeNavigator() {
            loader = new TreeLoader();
            root = loader.root;
            current = root;
        }

        public static TreeNavigator Instance
        {
            get
            {
                if (navigator == null)
                {
                    navigator = new TreeNavigator();
                }
                return navigator;
            }
        }

        // answer = 1 (yes) or = 0 (no)
        public Question GetNext(bool answer) {
            parent = current;

            if (answer)
                current = current.Yes;
            else
                current = current.No;

            return current;
        }

        public void UpdateTree(string quest, string answer) {
            Question q = new Question();
            q.QuestionLabel = quest;
            q.Yes = new Question();
            q.Yes.QuestionLabel = "Is it " + answer + "?";

            parent.No = q;
        }

        public void Reset() {
            current = root;
        }

        public void Save() {
            loader.SaveTree(root);
        }

    }
}
