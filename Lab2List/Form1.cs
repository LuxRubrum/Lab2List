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
            numList.generate((int)numSize.Value, (int)numMin.Value, (int)numMax.Value);
            lbxMain.Items.Add($"Лист создан, размер: {numList.nums.Count}");
            refreshLbxList();
        }

        private void btnCleanse_Click(object sender, EventArgs e)
        {
            numList.cleanse();
            lbxMain.Items.Add("Убраны значения, не делимые на первое значение.");
            lbxMain.Items.Add($"Текущее количество элементов списка: {numList.nums.Count}.");
            refreshLbxList();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            numList.divide();
            lbxMain.Items.Add("Добавлены нули между значениями одной чётности.");
            lbxMain.Items.Add($"Текущее количество элементов списка: {numList.nums.Count}.");
            refreshLbxList();
        }

        private void refreshLbxList()
        {
            lbxList.Items.Clear();
            foreach (int i in numList.nums)
            {
                lbxList.Items.Add(i.ToString());
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lbxMain.Items.Clear();
            lbxList.Items.Clear();
        }
    }
}
