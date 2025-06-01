namespace Lab2List
{
    public partial class frmMain : Form
    {
        NumList numList;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            numList = new NumList();
            lbxMain.Items.Add("Форма готова к работе.");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            numList.Generate((int)numSize.Value, (int)numMin.Value, (int)numMax.Value);
            lbxMain.Items.Add($"Лист создан, размер: {numList.nums.Count}");
            refreshLbxList();
        }

        private void btnCleanse_Click(object sender, EventArgs e)
        {
            numList.Cleanse();
            lbxMain.Items.Add("Убраны значения, не делимые на первое значение.");
            lbxMain.Items.Add($"Текущее количество элементов списка: {numList.nums.Count}.");
            refreshLbxList();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            numList.Divide();
            lbxMain.Items.Add("Добавлены нули между значениями одной чётности.");
            lbxMain.Items.Add($"Текущее количество элементов списка: {numList.nums.Count}.");
            refreshLbxList();
        }

        private void refreshLbxList()
        {
            lbxList.Items.Clear();
            if (numList.nums != null)
            {
                foreach (int i in numList.nums)
                {
                    lbxList.Items.Add(i.ToString());
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lbxMain.Items.Clear();
            lbxList.Items.Clear();
        }

        private void btnLambda_Click(object sender, EventArgs e)
        {
            int even = numList.CountEven(x => x % 2 == 0);
            lbxMain.Items.Add("Подсчитано количество чётных и нечётных значений.");
            lbxMain.Items.Add($"Количество чётных значений: {even}.");
            lbxMain.Items.Add($"Количество нечётных значений: {numList.nums.Count - even}.");
            refreshLbxList();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int res = LINQThings.WithFor();
            lbxMain.Items.Add("Посчитано методом с использованием for.");
            lbxMain.Items.Add($"Результат: {res}.");
            refreshLbxList();
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            int res = LINQThings.WithForeach();
            lbxMain.Items.Add("Посчитано методом с использованием foreach.");
            lbxMain.Items.Add($"Результат: {res}.");
            refreshLbxList();
        }

        private void btnOps_Click(object sender, EventArgs e)
        {
            int res = LINQThings.WithLINQOps();
            lbxMain.Items.Add("Посчитано методом с использованием операторов запросов LINQ.");
            lbxMain.Items.Add($"Результат: {res}.");
            refreshLbxList();
        }

        private void btnMets_Click(object sender, EventArgs e)
        {
            int res = LINQThings.WithLINQMets();
            lbxMain.Items.Add("Посчитано методом с использованием методов расширений LINQ.");
            lbxMain.Items.Add($"Результат: {res}.");
            refreshLbxList();
        }
    }
}
