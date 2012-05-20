using System;
using System.Drawing;
using System.Windows.Forms;

class MForm9 : Form {

    StatusBar sb;

    public MForm9() {
        Text = "TreeView";
        Size = new Size(250, 250);

        TreeView tv = new TreeView();

        TreeNode root = new TreeNode();
        root.Text = "Languages";

        TreeNode child1 = new TreeNode();
        child1.Text = "Python";

        TreeNode child2 = new TreeNode();
        child2.Text = "Ruby";

        TreeNode child3 = new TreeNode();
        child3.Text = "Java";

        root.Nodes.AddRange(new TreeNode[] {child1, child2, child3});

        tv.Parent = this;
        tv.Nodes.Add(root);
        tv.Dock = DockStyle.Fill;
        tv.AfterSelect += new TreeViewEventHandler(AfterSelect);

        sb = new StatusBar();
        sb.Parent = this;

        CenterToScreen();
    }

    void AfterSelect(object sender, TreeViewEventArgs e)
    {
        sb.Text = e.Node.Text;
    }
}

/*class MApplication {
    public static void Main() {
        Application.Run(new MForm9());
    }
}*/