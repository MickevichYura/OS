using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace lab10
{
    public static class LoadAndSave
    {
        #region Save (SaveTree, saveNode)

        public static void SaveTree(TreeView tree, string filename)
        {
            ArrayList al = new ArrayList();
            foreach (TreeNode tn in tree.Nodes)
            {
                al.Add(tn);
            }
            Stream file = File.Open(filename, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                bf.Serialize(file, al);
            }
            catch (System.Runtime.Serialization.SerializationException e)
            {
                MessageBox.Show("Serialization failed : {0}", e.Message);
            }
            finally
            {
                file.Close();
            }
        }

        #endregion


        #region Load (LoadTree, searchNode)

        public static void LoadTree(TreeView tree, string filename)
        {
            if (File.Exists(filename))
            {
                Stream file = File.Open(filename, FileMode.Open);

                BinaryFormatter bf = new BinaryFormatter();

                object obj;
                try
                {
                    obj = bf.Deserialize(file);
                }
                catch (System.Runtime.Serialization.SerializationException e)
                {
                    MessageBox.Show("De-Serialization failed : {0}", e.Message);
                    return;
                }
                finally
                {
                    file.Close();
                }
             
                ArrayList nodeList = obj as ArrayList;

                foreach (TreeNode node in nodeList)
                {
                    tree.Nodes.Add(node);
                }
            }
        }

        #endregion
    }
}
