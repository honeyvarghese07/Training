using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TreeViewBL;


namespace Registration_App
{
    public partial class TreeView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = TreeViewBL.TreeViewBL.GetData("select Id,Name from Brands");
            this.PopulateTreeView(dt, 0, null);
        }
        public void PopulateTreeView(DataTable dtParent, int ParentId, TreeNode treeNode)  
        {
                foreach (DataRow row in dtParent.Rows)
                {
                    TreeNode child = new TreeNode
                    {
                        Text = row["Name"].ToString(),
                        Value = row["Id"].ToString()
                    };

                    if (ParentId == 0)
                    {
                        treeview1.Nodes.Add(child);
                        DataTable dtChild = TreeViewBL.TreeViewBL.GetData("Select Id,Name from Product where BrandId=" + child.Value);
                        PopulateTreeView(dtChild, int.Parse(child.Value), child);
                    }
                    else
                    {
                        treeNode.ChildNodes.Add(child);
                    }
                }
            }
    }
}