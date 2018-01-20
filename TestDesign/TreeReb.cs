using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace TestDesign
{
    public partial class TreeReb : UserControl
    {
        // создание переменных для подключения к базе и для SQL запроса
        #region Код ADO
        private const string conString = @"Server=DESKTOP-PCECLDC\SQLEXPRESS; Initial Catalog=Sample; Integrated Security=True; Pooling=True; Connection Timeout=60;";
        private const string conStringInDll = "context connection=true";

        private const string withCTE = @"IF OBJECT_ID ('tempdb..#TreeBuild') is not null DROP TABLE #TreeBuild;
                                            with CTE as 
                                            ( select * ";
        private const string asLVL0 = ",0 as lvl ";
        private const string fromDBO = "from [dbo].[AddressTree] (nolock) where ";
        private const string ifValue = "[Value] ";
        private static string sqlValue = "";
        private const string andIdent = " and [Ident] = '";
        private static string sqlIdent = "";
        private const string sqlApostrof = "'";
        private const string unionAll = @" union all
                                            select Adt.* ";
        private const string asLVL1 = ",1 as lvl ";
        private const string fromAdt = @"from [dbo].[AddressTree] as Adt (nolock)
                                            inner join CTE as c1 on Adt.ParentID = c1.ID
                                            )
                                            select ID, ParentID, [Value] + ' ' + [Ident] + '||' + cast(LevelAddr as varchar(1)) as FullValue, LevelAddr ";
        private const string LVL01 = ",lvl ";
        private const string LVLforInto = ",0 as lvl ";
        private const string intoTree = "into #TreeBuild ";
        private const string fromCTE = "from CTE ";
        private const string where = "where ";
        private const string valueLike = "[Value] ";
        private static string ifValueLike = "";
        private const string identLike = "and [Ident] = '";
        private static string ifIdentLike = "";
        private const string sqlApostraf1 = "'";
        private const string orderBY = "order by [LevelAddr], [Value] ";
        private const string nextOTB = @";WITH OTB
                                            AS
                                            (
	                                        select ID, ParentID, FullValue, LevelAddr, lvl from #TreeBuild
	                                        UNION all
	                                        select Adt.ID, Adt.ParentID, 
                                                Adt.[Value] + ' ' + Adt.[Ident] + '||' + cast(Adt.LevelAddr as varchar(1)) as FullValue,
                                                Adt.LevelAddr, 1 as lvl 
                                            from [dbo].[AddressTree] as Adt (nolock)
	                                        inner join OTB as c1 on Adt.ParentID = c1.ID
                                            )
                                            SELECT * FROM OTB";

        private static string ifID = "[ID] = ";
        private static string sqlID = "";
        private static string ifParentID = "ParentID = ";
        private static string ParentID = "";
        private static string sqlAddIdent = "";
        private static string sqlAddValue = "";
        private static string sqlAddId = "";
        private static string cSqlQueryFinally = "";

        #endregion

        private TreeNode selectNode1; //для хранения выделенного узла дерева 
        private TreeNode selectNode2;

        private static string[] treeValues = new string[5]; //массив значений для формы редактирования EditTreeForm

        // определение статического контрола для добавления его на основную форму
        private static TreeReb _treeReb;
        public static TreeReb TreeRebuild
        {
            get
            {
                if (_treeReb == null)
                {
                    _treeReb = new TreeReb();
                }
                return _treeReb;
            }
        }

        // конструктор
        public TreeReb()
        {
            InitializeComponent();
            
            // всплывающие подсказки
            toolTipTopCtrl.SetToolTip(backButton, "Back");
            toolTipTopCtrl.SetToolTip(nextButton, "Forward");
            toolTipTopCtrl.SetToolTip(editButton, "Edit");
            toolTipTopCtrl.SetToolTip(addButton, "Add");
            toolTipTopCtrl.SetToolTip(removeButton, "Remove");
            toolTipTopCtrl.SetToolTip(refreshButton, "Refresh");
            toolTipTopCtrl.SetToolTip(searchButton, "Search");
            toolTipTopCtrl.SetToolTip(infoButton, "Info");
            toolTipTopCtrl.SetToolTip(clearButton, "Clear");

            //скрытие сплиттера при загрузке
            //splitter1.Hide();
        }

                    // события \\
        // 1. вывод выбранной в листе строки в datagridview
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataGridBuild(sender, e, true);
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataGridBuild(sender, e, false);
        }

        // 2. при изменении размера формы выставление сплиттера ровно по центру
        private void TreeReb_SizeChanged(object sender, EventArgs e)
        {
            this.panel2.Width = TreeRebuild.Width / 2 - 2;
        }

        // 3. при клике на дерево снимается выделение предыдущего дерева
        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            this.selectNode2 = this.treeView2.SelectedNode;
            this.treeView2.SelectedNode = null;

            if (this.selectNode1 != null)
            {
                this.treeView1.SelectedNode = this.selectNode1;
            }
        }

        private void treeView2_MouseClick(object sender, MouseEventArgs e)
        {
            this.selectNode1 = this.treeView1.SelectedNode;
            this.treeView1.SelectedNode = null;

            if(this.selectNode2 != null)
            {
                this.treeView2.SelectedNode = this.selectNode2;
            }
        }

                    // кнопки \\
        // 1. Поиск
        private void searchButton_Click(object sender, EventArgs e)
        {
            //FindTreeForm findTree = new FindTreeForm();
            //findTree.Show();

            FindTreeForm.FindTree.Show();
        }

        // 2. Очистка
        private void clearButton_Click(object sender, EventArgs e)
        {
            TreeRebuild.treeView1.Nodes.Clear();
            TreeRebuild.treeView2.Nodes.Clear();
            TreeRebuild.dataGridView1.DataSource = null;
            TreeRebuild.dataGridView2.DataSource = null;
        }

        // 3. Обновить
        private void refreshButton_Click(object sender, EventArgs e)
        {
            treeView1.Refresh();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditTreeForm.EditTree.Show();
            EditTreeForm.EditTreeFormFill(treeValues);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode != null)
            {
                this.treeView1.SelectedNode = this.treeView1.SelectedNode.NextVisibleNode;
                this.treeView1.Focus();
            }
            else if (this.treeView2.SelectedNode != null)
            {
                this.treeView2.SelectedNode = this.treeView2.SelectedNode.NextVisibleNode;
                this.treeView2.Focus(); 
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode != null)
            {
                this.treeView1.SelectedNode = this.treeView1.SelectedNode.PrevVisibleNode;
                this.treeView1.Focus();
            }
            else if (this.treeView2.SelectedNode != null)
            {
                this.treeView2.SelectedNode = this.treeView2.SelectedNode.PrevVisibleNode;
                this.treeView2.Focus();
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {

        }

                    // методы \\
        // 1. Вывод дерева
        public static bool OutPutTree(string[] sqlVal)
        {
            bool flag = true;

            sqlValue = sqlVal[0];
            sqlIdent = sqlVal[1];
            sqlID = sqlVal[2];
            ifIdentLike = sqlVal[3];
            ifValueLike = sqlVal[4];
            sqlAddIdent = sqlVal[5];
            sqlAddValue = sqlVal[6];
            sqlAddId = sqlVal[7];

            //очистка дерева перед построением нового
            dt1.Clear(); 
            dt2.Clear();

            // проверка корректности sql синтаксиса в переменной, чтобы не было ошибок выполнения
            if (!Regex.IsMatch(sqlValue, @"^=[ ]*'.*'$") && !Regex.IsMatch(sqlValue, @"^like[ ]*'.*'$"))
            {
                sqlValue = "";
            }
            if (!Regex.IsMatch(ifValueLike, @"^=[ ]*'.*'$") && !Regex.IsMatch(ifValueLike, @"^like[ ]*'.*'$")) 
            {
                ifValueLike = "";
            }
            if (!Regex.IsMatch(sqlAddValue, @"^=[ ]*'.*'$") && !Regex.IsMatch(sqlAddValue, @"^like[ ]*'.*'$")) 
            {
                sqlAddValue = "";
            }

            if ((sqlValue != "" || sqlIdent != "") && sqlID != "")
            {
                MessageBox.Show("Поиск работает либо по значению поля \"Value\", либо по \"ID\". Очистите одно из полей.");
                flag = false;
            }
            else if ((ifIdentLike != "" || ifValueLike != "") && (sqlValue == "" && sqlID == ""))
            {
                MessageBox.Show("Сначала необходимо заполнить поля в разделе \"Найти узел\".");
                flag = false;
            }
            else if (ifIdentLike != "" && ifValueLike == "" && (sqlValue != "" || sqlID != ""))
            {
                MessageBox.Show("Укажите значение в поле \"Value\" или удалите значение из поля \"Ident\" раздела \"Найти подузел\".");
                flag = false;
            }
            else if (sqlValue == "" && sqlID == "" && sqlAddValue == "" && sqlAddId == "")
            {
                flag = false;
            }

            if (flag)
            {
                if (sqlValue != "" || sqlID != "")
                {
                    SqlQueryBuild(true);
                    DataTableCreate(true);
                    FillRootNodes(true); //MessageBox.Show(cSqlQueryFinally);
                }

                if (sqlAddValue != "" || sqlAddId != "")
                {
                    SqlQueryBuild(false);
                    DataTableCreate(false);
                    FillRootNodes(false);
                }
            }

            if (TreeRebuild.treeView1.Nodes.Count > 0 || TreeRebuild.treeView2.Nodes.Count > 0)
            {
                flag = true;
                TreeRebuild.treeView1.Focus();
                TreeRebuild.treeView2.Focus();
                TreeRebuild.treeView1.Focus(); 
                //TreeRebuild.panel2.Width = TreeRebuild.Width;
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        // 2. построение SQL запроса в зависимости от заполненных полей
        private static void SqlQueryBuild(bool choice)
        {
            cSqlQueryFinally = "";
            if (choice)
            {
                if (sqlValue != "" && sqlIdent != "" && sqlID == "" && ifValueLike == "")
                {
                    cSqlQueryFinally = withCTE + asLVL0 + fromDBO + ifValue + sqlValue + andIdent + sqlIdent + sqlApostrof + unionAll + asLVL1 + fromAdt + LVL01 + fromCTE;
                }
                else if (sqlValue != "" && sqlIdent == "" && sqlID == "" && ifValueLike == "")
                {
                    cSqlQueryFinally = withCTE + asLVL0 + fromDBO + ifValue + sqlValue + unionAll + asLVL1 + fromAdt + LVL01 + fromCTE;
                }
                else if (sqlValue == "" && sqlIdent == "" && sqlID != "" && ifValueLike == "")
                {
                    cSqlQueryFinally = withCTE + asLVL0 + fromDBO + ifID + sqlID + unionAll + asLVL1 + fromAdt + LVL01 + fromCTE;
                }
                //если заполненны поля подузла
                else if (sqlValue != "" && sqlIdent != "" && sqlID == "" && ifValueLike != "" && ifIdentLike != "")
                {
                    cSqlQueryFinally = withCTE + fromDBO + ifValue + sqlValue + andIdent + sqlIdent + sqlApostrof + unionAll + fromAdt + LVLforInto + intoTree
                                            + fromCTE + where + valueLike + ifValueLike + identLike + ifIdentLike + sqlApostraf1 + orderBY + nextOTB;
                }
                else if (sqlValue != "" && sqlIdent != "" && sqlID == "" && ifValueLike != "" && ifIdentLike == "")
                {
                    cSqlQueryFinally = withCTE + fromDBO + ifValue + sqlValue + andIdent + sqlIdent + sqlApostrof + unionAll + fromAdt + LVLforInto + intoTree
                                            + fromCTE + where + valueLike + ifValueLike + orderBY + nextOTB;
                }
                else if (sqlValue != "" && sqlIdent == "" && sqlID == "" && ifValueLike != "" && ifIdentLike != "")
                {
                    cSqlQueryFinally = withCTE + fromDBO + ifValue + sqlValue + unionAll + fromAdt + LVLforInto + intoTree
                                            + fromCTE + where + valueLike + ifValueLike + identLike + ifIdentLike + sqlApostraf1 + orderBY + nextOTB;
                }
                else if (sqlValue != "" && sqlIdent == "" && sqlID == "" && ifValueLike != "" && ifIdentLike == "")
                {
                    cSqlQueryFinally = withCTE + fromDBO + ifValue + sqlValue + unionAll + fromAdt + LVLforInto + intoTree
                                            + fromCTE + where + valueLike + ifValueLike + orderBY + nextOTB;
                }
                else if (sqlValue == "" && sqlIdent == "" && sqlID != "" && ifValueLike != "" && ifIdentLike != "")
                {
                    cSqlQueryFinally = withCTE + fromDBO + ifID + sqlID + unionAll + fromAdt + LVLforInto + intoTree
                                            + fromCTE + where + valueLike + ifValueLike + identLike + ifIdentLike + sqlApostraf1 + orderBY + nextOTB;
                }
                else if (sqlValue == "" && sqlIdent == "" && sqlID != "" && ifValueLike != "" && ifIdentLike == "")
                {
                    cSqlQueryFinally = withCTE + fromDBO + ifID + sqlID + unionAll + fromAdt + LVLforInto + intoTree
                                            + fromCTE + where + valueLike + ifValueLike + orderBY + nextOTB;
                }
            }
            else
            {
                if (sqlAddValue != "" && sqlAddIdent != "" && sqlAddId == "")
                {
                    cSqlQueryFinally = withCTE + asLVL0 + fromDBO + ifValue + sqlAddValue + andIdent + sqlAddIdent + sqlApostrof + unionAll + asLVL1 + fromAdt + LVL01 + fromCTE;
                }
                else if (sqlAddValue != "" && sqlAddIdent == "" && sqlAddId == "")
                {
                    cSqlQueryFinally = withCTE + asLVL0 + fromDBO + ifValue + sqlAddValue + unionAll + asLVL1 + fromAdt + LVL01 + fromCTE;
                }
                else if (sqlAddValue == "" && sqlAddIdent == "" && sqlAddId != "")
                {
                    cSqlQueryFinally = withCTE + asLVL0 + fromDBO + ifID + sqlAddId + unionAll + asLVL1 + fromAdt + LVL01 + fromCTE;
                }
            }
        }

        // 3. заполнение таблицы в памяти
        private static DataTable dt1 = new DataTable();
        private static DataTable dt2 = new DataTable();
        [SqlFunction(DataAccess = DataAccessKind.Read, SystemDataAccess = SystemDataAccessKind.Read)]
        private static void DataTableCreate(bool choice)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand(cSqlQueryFinally, con))
                    {
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(com))
                        {
                            if (choice)
                            {
                                dataAdapter.Fill(dt1);
                            }
                            else
                            {
                                dataAdapter.Fill(dt2);
                            }
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex) { }
        }

        // 4. получаем корни
        private static void FillRootNodes(bool treeviewChoise) //ошибка, если вводить символ в value
        {
            DataRow[] dataRow;
            if (treeviewChoise)
            {
                TreeRebuild.treeView1.Nodes.Clear();
                dataRow = dt1.Select("lvl = 0");
            }
            else
            {
                TreeRebuild.treeView2.Nodes.Clear();
                dataRow = dt2.Select("lvl = 0");
            }
            try
            {
                //DataRow[] dataRow = dt.Select("lvl = 0"); 
                foreach (DataRow dr in dataRow)
                {
                    TreeNode treeNode = new TreeNode(dr["FullValue"].ToString());
                    if (treeviewChoise)
                    {
                        TreeRebuild.treeView1.Nodes.Add(treeNode);
                        treeNode.Tag = dr["ID"];
                        FillTreeNode(treeNode, dt1);
                    }
                    else
                    {
                        TreeRebuild.treeView2.Nodes.Add(treeNode);
                        treeNode.Tag = dr["ID"];
                        FillTreeNode(treeNode, dt2);
                    }
                }
            }
            catch (Exception ex) { }
        }

        // 5. получаем дочерние узлы для определенного узла
        private static void FillTreeNode(TreeNode treeNode, DataTable data)
        {
            try
            {
                DataRow[] dataRow = data.Select($"ParentID = {treeNode.Tag}");
                foreach (DataRow dr in dataRow)
                {
                    TreeNode childNode = new TreeNode(dr["FullValue"].ToString());
                    treeNode.Nodes.Add(childNode);
                    childNode.Tag = dr["ID"];
                    FillTreeNode(childNode, data);
                }
            }
            catch (Exception ex) { }
        }

        // 6. построение datagridview на основе выделенного значения в treeview
        private void DataGridBuild(object sender, TreeViewEventArgs e, bool choice)
        {
            DataTable table;
            if (choice)
            {
                table = dt1.Select($"ID = '{e.Node.Tag.ToString()}'").CopyToDataTable();
                table.Columns.Remove("lvl");

                dataGridView1.DataSource = table; //dataGridView1.RowHeadersVisible = false;

                MassifForEditTreeFormFill(table);
            }
            else
            {
                table = dt2.Select($"ID = '{e.Node.Tag.ToString()}'").CopyToDataTable();
                table.Columns.Remove("lvl");

                dataGridView2.DataSource = table;
            }
        }

        // 7. заполнение массива, хранящего значения полей записи дерева, для передачи его в форму редактирования
        private void MassifForEditTreeFormFill(DataTable table)
        {
            DataRow[] row;
            row = table.Select();
            treeValues[0] = row[0]["ID"].ToString();
            treeValues[1] = row[0]["ParentID"].ToString();
            treeValues[2] = row[0]["FullValue"].ToString();
            treeValues[3] = "ident";
            treeValues[4] = row[0]["LevelAddr"].ToString(); 
        }
    }
}
