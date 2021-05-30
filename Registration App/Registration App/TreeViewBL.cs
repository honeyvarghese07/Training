using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;
using TreeBuilder;

namespace TreeViewBL
{
    public class TreeViewBL
    {
        public static DataTable GetData(String Query)
        {
            try
            {
                DataTable dt = new DataTable();
                TreeBuilderDL treeObj = new TreeBuilderDL();
                dt = treeObj.ExecuteCommand(Query, CommandType.Text); 
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}