using BlocknotWithRepo.Data.Abstract;
using BlocknotWithRepo.Data.Concrete;
using BlocknotWithRepo.Data.Entities;

namespace BlocknotWithRepo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            this.Load += FormMain_Load;
        }

        private void FormMain_Load(object? sender, EventArgs e)
        {
            using (IRepository<Record> recordRepo = new RecordRepository())
            {
                var records = recordRepo.GetAll();

                this.listBox1.Items.AddRange(records.ToArray());
            }
        }
    }
}