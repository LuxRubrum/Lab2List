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
            lbxMain.Items.Add("����� ������ � ������.");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            numList.generate((int)numSize.Value, (int)numMin.Value, (int)numMax.Value);
            lbxMain.Items.Add($"���� ������, ������: {numList.nums.Count}");
            refreshLbxList();
        }

        private void btnCleanse_Click(object sender, EventArgs e)
        {
            numList.cleanse();
            lbxMain.Items.Add("������ ��������, �� ������� �� ������ ��������.");
            lbxMain.Items.Add($"������� ���������� ��������� ������: {numList.nums.Count}.");
            refreshLbxList();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            numList.divide();
            lbxMain.Items.Add("��������� ���� ����� ���������� ����� ��������.");
            lbxMain.Items.Add($"������� ���������� ��������� ������: {numList.nums.Count}.");
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
